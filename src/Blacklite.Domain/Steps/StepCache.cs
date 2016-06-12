using System;
using System.Collections;
using System.Collections.Generic;

namespace Blacklite.Domain.Steps
{
    public interface IStepCache<TStep, TReturn> : IStepContainer<TReturn>
        where TStep : IStep
    {
    }

    public abstract class StepCache<TStep, TReturn> : IStepCache<TStep, TReturn>
        where TStep : IStep
    {
        private IStepContainer<TReturn> _cache;

        public StepCache(IEnumerable<TStep> steps) { }

        public IEnumerable<IStepDescriptor<TReturn>> BuildStepDescriptors(IEnumerable<TStep> steps) => steps.GetStepDescriptors<TStep, TReturn>();

        public void ResetCache(IEnumerable<IStepDescriptor<TReturn>> descriptors)
        {
            _cache = new StepContainer<TReturn>(descriptors);
        }

        public IEnumerator<IStepDescriptor<TReturn>> GetEnumerator() => _cache.GetEnumerator();

        public IEnumerable<IStepDescriptor<TReturn>> GetStepsForContext<T>() => _cache.GetStepsForContext<T>();
        public IEnumerable<IStepDescriptor<TReturn>> GetStepsForContext(Type type) => _cache.GetStepsForContext(type);

        IEnumerator IEnumerable.GetEnumerator() => _cache.GetEnumerator();
    }

    class DefaultStepCache<TStep, TReturn> : StepCache<TStep, TReturn>
        where TStep : IStep
    {
        public DefaultStepCache(IEnumerable<TStep> steps) : base(steps)
        {
            ResetCache(BuildStepDescriptors(steps));
        }
    }
}
