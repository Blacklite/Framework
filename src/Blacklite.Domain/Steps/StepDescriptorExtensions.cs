using System;
using System.Collections.Generic;
using System.Linq;
using Blacklite.TopographicalSort;

namespace Blacklite.Domain.Steps
{
    public static class StepDescriptorExtensions
    {
        public static IEnumerable<IStepDescriptor<TReturn>> GetStepDescriptors<TStep, TReturn>(this IEnumerable<TStep> steps)
            where TStep : IStep
        {
            var overrideDescriptors = new List<StepDescriptor<TReturn>>();

            var descriptors = steps
                // Create the desciptor
                .Select(step => StepDescriptor<TReturn>.Create(steps, overrideDescriptors, step))
                .ToArray()
                // Exclude anyones that are part of depdendencies or overrides
                .Except(overrideDescriptors)
                // Include the ones that were added as part of creation
                .Concat(overrideDescriptors)
                // Make sure we only have a unique list (one per step)
                .Distinct()
                .ToArray();

            if (steps.Count() != descriptors.Count())
                throw new IndexOutOfRangeException();

            // Fixup all the descriptors to normalize before / after.
            foreach (var d in descriptors)
                d.Fixup(descriptors);

            return descriptors.TopographicalSort(x => x.DependsOn);
        }
    }
}
