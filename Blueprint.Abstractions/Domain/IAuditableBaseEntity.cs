using System;

namespace Blueprint.Abstractions.Domain
{
  internal interface IAuditableBaseEntity : IBaseEntity
  {
    string CreatedBy { get; set; }

    DateTime CreatedOn { get; set; }

    string LastModifiedBy { get; set; }

    DateTime? LastModifiedOn { get; set; }
  }
}
