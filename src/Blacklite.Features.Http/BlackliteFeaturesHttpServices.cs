using Blacklite.Features.Composition;
using Blacklite.Features.Describers;
using Blacklite.Features.Factory;
using Blacklite.Features.OptionsModel;
using Blacklite.Features.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Blacklite.Features.Http
{
    public static class BlackliteFeaturesHttpServices
    {
        internal static IEnumerable<ServiceDescriptor> GetFeaturesHttp(IServiceCollection services)
        {
            return Enumerable.Empty<ServiceDescriptor>();
        }
    }
}
