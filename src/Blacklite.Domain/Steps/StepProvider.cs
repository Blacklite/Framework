using System.Collections.Generic;
using System.Linq;

namespace Blacklite.Domain.Steps
{
    public interface IStepProvider<TStep, TReturn>
        where TStep : IStep
    {
        /// <summary>
        /// Get a list of all steps for the given phase
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="phase"></param>
        /// <param name="instance"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        IEnumerable<IStepDescriptor<TReturn>> GetSteps<T>([NotNull] T instance);
    }

    public class StepProvider<TStep, TReturn> : IStepProvider<TStep, TReturn>
        where TStep : IStep
    {
        protected IStepCache<TStep, TReturn> StepCache { get; }

        public StepProvider(IStepCache<TStep, TReturn> stepCache)
        {
            StepCache = stepCache;
        }

        public IEnumerable<IStepDescriptor<TReturn>> GetSteps<T>(T instance)
        {
            return StepCache.GetStepsForContext<T>().Where(x => x.CanExecute(instance));
        }
    }
}
