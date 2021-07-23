﻿using Blueprint.Common.EntityFrameworkCore.AuditTrail.Enums;
using Blueprint.Common.EntityFrameworkCore.AuditTrail.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Blueprint.Common.EntityFrameworkCore.AuditTrail
{
    public abstract class AuditableContext : DbContext
    {
        public AuditableContext(DbContextOptions options)
          : base(options)
        {
        }

        public DbSet<Audit> AuditLogs { get; set; }

        public virtual async Task<int> SaveChangesAsync(string userId = null)
        {
            List<AuditEntry> auditEntries = OnBeforeSaveChanges(userId);
            // ISSUE: reference to a compiler-generated method
            int result = await SaveChangesAsync(new CancellationToken());
            await OnAfterSaveChanges(auditEntries);
            int num = result;
            auditEntries = null;
            return num;
        }

        private List<AuditEntry> OnBeforeSaveChanges(string userId)
        {
            ChangeTracker.DetectChanges();
            List<AuditEntry> source = new List<AuditEntry>();
            foreach (EntityEntry entry in ChangeTracker.Entries())
            {
                if (!(entry.Entity is Audit) && entry.State != EntityState.Detached && entry.State != EntityState.Unchanged)
                {
                    AuditEntry auditEntry = new AuditEntry(entry);
                    auditEntry.TableName = entry.Entity.GetType().Name;
                    auditEntry.UserId = userId;
                    source.Add(auditEntry);
                    foreach (PropertyEntry property in entry.Properties)
                    {
                        if (property.IsTemporary)
                        {
                            auditEntry.TemporaryProperties.Add(property);
                        }
                        else
                        {
                            string name = property.Metadata.Name;
                            if (property.Metadata.IsPrimaryKey())
                            {
                                auditEntry.KeyValues[name] = property.CurrentValue;
                            }
                            else
                            {
                                switch (entry.State)
                                {
                                    case EntityState.Deleted:
                                        auditEntry.AuditType = AuditType.Delete;
                                        auditEntry.OldValues[name] = property.OriginalValue;
                                        continue;
                                    case EntityState.Modified:
                                        if (property.IsModified)
                                        {
                                            auditEntry.ChangedColumns.Add(name);
                                            auditEntry.AuditType = AuditType.Update;
                                            auditEntry.OldValues[name] = property.OriginalValue;
                                            auditEntry.NewValues[name] = property.CurrentValue;
                                            continue;
                                        }
                                        continue;
                                    case EntityState.Added:
                                        auditEntry.AuditType = AuditType.Create;
                                        auditEntry.NewValues[name] = property.CurrentValue;
                                        continue;
                                    default:
                                        continue;
                                }
                            }
                        }
                    }
                }
            }
            foreach (AuditEntry auditEntry in source.Where(_ => !_.HasTemporaryProperties))
                AuditLogs.Add(auditEntry.ToAudit());
            return source.Where(_ => _.HasTemporaryProperties).ToList();
        }

        private Task OnAfterSaveChanges(List<AuditEntry> auditEntries)
        {
            if (auditEntries == null || auditEntries.Count == 0)
                return Task.CompletedTask;
            foreach (AuditEntry auditEntry in auditEntries)
            {
                foreach (PropertyEntry temporaryProperty in auditEntry.TemporaryProperties)
                {
                    if (temporaryProperty.Metadata.IsPrimaryKey())
                        auditEntry.KeyValues[temporaryProperty.Metadata.Name] = temporaryProperty.CurrentValue;
                    else
                        auditEntry.NewValues[temporaryProperty.Metadata.Name] = temporaryProperty.CurrentValue;
                }
                AuditLogs.Add(auditEntry.ToAudit());
            }
            return SaveChangesAsync(null);
        }
    }
}
