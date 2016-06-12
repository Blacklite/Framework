using Microsoft.Extensions.Logging;
using System;

namespace Blacklite.Multitenancy
{
    [TenantOnly]
    public interface ITenantLogger : ILogger { }
}
