using System;

namespace Blacklite.Multitenancy
{
    [ApplicationOnly]
    public interface ITenantScope : IDisposable
    {
        ITenant Tenant { get; }
        IServiceProvider ServiceProvider { get; }
    }
}
