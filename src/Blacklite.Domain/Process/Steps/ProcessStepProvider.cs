using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Blacklite.Domain.Steps;

namespace Blacklite.Domain.Process.Steps
{
    public interface IDomainStepProvider : IPhasedStepProvider<IProcessStep, IEnumerable<IValidation>>
    {
        /// <summary>
        /// Get a grouping of all steps for the current given stage.
        /// </summary>
        /// <typeparam name = "T"></typeparam>
        /// <param name = "stage"></param>
        /// <param name = "context"></param>
        /// <param name = "instance"></param>
        /// <returns></returns>
        IEnumerable<IGrouping<IStepPhase, IStepDescriptor<IEnumerable<IValidation>>>> GetStepsForStage(
            [NotNull] string stage,
            [NotNull] Type type);
    }

    class ProcessStepProvider : PhasedStepProvider<IProcessStep, IEnumerable<IValidation>>, IDomainStepProvider
    {
        private readonly IReadOnlyDictionary<string, IEnumerable<IStepPhase>> _stages;
        public ProcessStepProvider(IPhasedStepCache<IProcessStep, IEnumerable<IValidation>> stepCache) : base(stepCache)
        {
            _stages = new ReadOnlyDictionary<string, IEnumerable<IStepPhase>>(stepCache.GroupBy(x => x.Key.Stage, x => x.Key).ToDictionary(x => x.Key, x => x.Distinct().OrderByDescending(z => z.Order).AsEnumerable()));
        }

        public IEnumerable<IGrouping<IStepPhase, IStepDescriptor<IEnumerable<IValidation>>>> GetStepsForStage(string stage, [NotNull] Type type)
        {
            IEnumerable<IStepPhase> phases;
            if (!_stages.TryGetValue(stage, out phases))
                return Enumerable.Empty<IGrouping<IStepPhase, IStepDescriptor<IEnumerable<IValidation>>>>();
            return phases.Select(x => new Grouping<IStepPhase, IStepDescriptor<IEnumerable<IValidation>>>(x, GetStepsForPhase(x, type)));
        }

        private class Grouping<TKey, TValue> : IGrouping<TKey, TValue>
        {
            public Grouping(TKey key, IEnumerable<TValue> values)
            {
                Key = key;
                Items = values;
            }

            public TKey Key { get; }

            private IEnumerable<TValue> Items { get; }

            public IEnumerator<TValue> GetEnumerator()
            {
                return Items.GetEnumerator();
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return Items.GetEnumerator();
            }
        }
    }
}
