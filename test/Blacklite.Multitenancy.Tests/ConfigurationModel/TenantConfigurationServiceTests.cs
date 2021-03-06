using Blacklite.Multitenancy;
using Blacklite.Multitenancy.Configuration;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Multitenancy.Tests.Configuration
{
    public class TenantConfigurationServiceTests
    {
        [Fact]
        public void ConfiguresDescriptions()
        {
            var service = new TenantConfigurationService(Enumerable.Empty<ITenantComposer>(), Enumerable.Empty<ITenantConfigurationComposer>());

            service.Configure(new Tenant(new TenantConfiguration(new List<IConfigurationSource>())));

            Assert.True(true);
        }
    }
}
