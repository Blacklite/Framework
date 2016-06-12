using System;

namespace Blacklite.Multitenancy
{
    [ApplicationOnly]
    public interface ITenantComposer
    {
        int Order { get; }
        void Configure(ITenant tenant, IServiceProvider tenantServiceProvider);
    }
}
