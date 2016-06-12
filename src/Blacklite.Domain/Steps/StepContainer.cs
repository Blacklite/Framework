using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Blacklite.Domain.Steps
{
    public interface IStepContainer<TReturn> : IEnumerable<IStepDescriptor<TReturn>>
    {
        IEnumerable<IStepDescriptor<TReturn>> GetStepsForContext<T>();
        IEnumerable<IStepDescriptor<TReturn>> GetStepsForContext(Type type);
    }

    /// <summary>
    /// Contains a cache of step descriptors, for any type that has come through for the phase that we're constructed for
    /// We don't know our phase (nor do we really care about it.)
    ///
    /// We also implement the enumerator to make it easy to list all steps in a phase.
    /// </summary>
    class StepContainer<TReturn> : IStepContainer<TReturn>
    {
        private readonly IEnumerable<IStepDescriptor<TReturn>> _descriptors;
        private readonly ConcurrentDictionary<Type, IEnumerable<IStepDescriptor<TReturn>>> _typeSteps = new ConcurrentDictionary<Type, IEnumerable<IStepDescriptor<TReturn>>>();

        public StepContainer(IEnumerable<IStepDescriptor<TReturn>> descriptors)
        {
            _descriptors = descriptors;
        }

        public IEnumerable<IStepDescriptor<TReturn>> GetStepsForContext<T>() => GetStepsForContext(typeof(T));
        public IEnumerable<IStepDescriptor<TReturn>> GetStepsForContext(Type type) =>
            _typeSteps.GetOrAdd(type, t => _descriptors
                                // Overrides are process steps that derive from the given step
                                // If they "CanRun" then this step, by it's nature should not run.
                                // because the "override" will also be in the list of possible steps for a given type.
                                // and we should not run the same step more than once.
                                .Where(d => d.CanRun(t)));

        public IEnumerator<IStepDescriptor<TReturn>> GetEnumerator() => _descriptors.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
