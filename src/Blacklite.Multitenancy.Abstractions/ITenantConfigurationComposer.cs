using Microsoft.Extensions.Configuration;
using System;

namespace Blacklite.Multitenancy
{
    [ApplicationOnly]
    public interface ITenantConfigurationComposer
    {
        string Key { get; }
        int Order { get; }
        void Configure(ITenant tenant, IConfiguration configuration);
    }
}
