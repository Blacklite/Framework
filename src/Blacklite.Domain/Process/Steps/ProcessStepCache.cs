using System.Collections.Generic;
using Blacklite.Domain.Steps;

namespace Blacklite.Domain.Process.Steps
{
    public interface IProcessStepCache : IPhasedStepCache<IProcessStep, IEnumerable<IValidation>>
    {

    }

    public class ProcessStepCache : PhasedStepCache<IProcessStep, IEnumerable<IValidation>>, IProcessStepCache
    {
        public ProcessStepCache(IEnumerable<IProcessStep> steps) : base(steps)
        {
        }
    }
}
