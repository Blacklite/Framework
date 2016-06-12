using Blacklite;
using Blacklite.Domain.Process;
using System;
using Blacklite.Domain;
using Blacklite.Domain.Steps;
using MediatR;
using Microsoft.Extensions.DependencyInjection.Extensions;
// ReSharper disable CheckNamespace

namespace Microsoft.Extensions.DependencyInjection
{
    public static class BlackliteDomainServiceCollectionExtensions
    {
        public static IServiceCollection AddDomainProcesses([NotNull] this IServiceCollection services)
        {
            ConfigureDefaultServices(services);
            services.TryAdd(BlackliteDomainServices.GetDefaultServices());
            return services;
        }

        private static void ConfigureDefaultServices(IServiceCollection services)
        {
            services.TryAddSingleton(typeof(IMediator), typeof(Mediator));
            services.TryAddScoped<SingleInstanceFactory>(p => t => p.GetRequiredService(t));
            services.TryAddScoped<MultiInstanceFactory>(p => t => p.GetServices(t));
        }
    }
}
