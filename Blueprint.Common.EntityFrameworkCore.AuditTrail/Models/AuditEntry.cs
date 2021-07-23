using Blueprint.Common.EntityFrameworkCore.AuditTrail.Enums;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Blueprint.Common.EntityFrameworkCore.AuditTrail.Models
{
  public class AuditEntry
  {
    public AuditEntry(EntityEntry entry) => this.Entry = entry;

    public EntityEntry Entry { get; }

    public string UserId { get; set; }

    public string TableName { get; set; }

    public Dictionary<string, object> KeyValues { get; } = new Dictionary<string, object>();

    public Dictionary<string, object> OldValues { get; } = new Dictionary<string, object>();

    public Dictionary<string, object> NewValues { get; } = new Dictionary<string, object>();

    public List<PropertyEntry> TemporaryProperties { get; } = new List<PropertyEntry>();

    public AuditType AuditType { get; set; }

    public List<string> ChangedColumns { get; } = new List<string>();

    public bool HasTemporaryProperties => this.TemporaryProperties.Any<PropertyEntry>();

    public Audit ToAudit() => new Audit()
    {
      UserId = this.UserId,
      Type = this.AuditType.ToString(),
      TableName = this.TableName,
      DateTime = DateTime.UtcNow,
      PrimaryKey = JsonConvert.SerializeObject((object) this.KeyValues),
      OldValues = this.OldValues.Count == 0 ? (string) null : JsonConvert.SerializeObject((object) this.OldValues),
      NewValues = this.NewValues.Count == 0 ? (string) null : JsonConvert.SerializeObject((object) this.NewValues),
      AffectedColumns = this.ChangedColumns.Count == 0 ? (string) null : JsonConvert.SerializeObject((object) this.ChangedColumns)
    };
  }
}
