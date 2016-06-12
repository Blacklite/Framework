using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Blacklite.Multitenancy.Configuration
{    [ApplicationOnly]
    public interface ITenantConfigurationService
    {
        void Configure(ITenant tenant, IServiceProvider tenantServiceProvider);
    }
}
