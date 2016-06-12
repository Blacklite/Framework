using System;
using System.Collections.Generic;
using System.Linq;
using Blacklite.Domain.Steps;

namespace Blacklite.Domain.Process.Steps
{
    public static class ProcessStepProviderExtensions
    {
        public static string Init { get; } = nameof(Init);
        public static string Save { get; } = nameof(Save);

        public static IEnumerable<IGrouping<IStepPhase, IStepDescriptor<IEnumerable<IValidation>>>> GetInitSteps(
            [NotNull] this IDomainStepProvider provider,
            [NotNull] Type type)
        {
            return provider.GetStepsForStage(Init, type);
        }

        public static IEnumerable<IGrouping<IStepPhase, IStepDescriptor<IEnumerable<IValidation>>>> GetSaveSteps(
            [NotNull] this IDomainStepProvider provider,
            [NotNull] Type type)
        {
            return provider.GetStepsForStage(Save, type);
        }
    }
}
