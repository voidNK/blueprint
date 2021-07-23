using Blueprint.Application.Interfaces.Shared;
using System;

namespace Blueprint.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}