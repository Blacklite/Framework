using System.Collections.Generic;
using Blacklite.Domain.Process.Requests;
using Blacklite.Domain.Process.Steps;
using Blacklite.Domain.Steps;
using Microsoft.Extensions.DependencyInjection;

namespace Blacklite.Domain
{
    public static class BlackliteDomainServices
    {
        public static IEnumerable<ServiceDescriptor> GetDefaultServices()
        {
            yield return ServiceDescriptor.Singleton(typeof(IStepProvider<,>), typeof(StepProvider<,>));
            yield return ServiceDescriptor.Singleton(typeof(IPhasedStepProvider<,>), typeof(PhasedStepProvider<,>));
            yield return ServiceDescriptor.Transient(typeof(IStepCache<,>), typeof(DefaultStepCache<,>));
            yield return ServiceDescriptor.Transient(typeof(IPhasedStepCache<,>), typeof(DefaultPhasedStepCache<,>));

            yield return ServiceDescriptor.Singleton(typeof(IDomainStepProvider), typeof(ProcessStepProvider));
            yield return ServiceDescriptor.Singleton(typeof(IProcessStepCache), typeof(ProcessStepCache));
            yield return ServiceDescriptor.Transient(typeof(IResponse<>), typeof(Response<>));
            yield return ServiceDescriptor.Transient(typeof(ISaveRequest<>), typeof(SaveRequest<>));
            yield return ServiceDescriptor.Transient(typeof(ISaveRequestHandler<>), typeof(SaveRequestHandler<>));
        }
    }
}
