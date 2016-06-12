using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Blacklite.Domain.Steps
{
    public interface IStepPhase : IEnumerable<IStepPhase>
    {
        string Stage { get; }
        int Order { get; }
    }

    public class StepPhase : IStepPhase
    {
        private readonly string _name;
        private readonly IEnumerable<StepPhase> _value;

        public StepPhase(string name, int order, string stage)
        {
            _name = name;
            Order = order;
            Stage = stage;
            _value = new[] { this }.AsEnumerable();
        }

        public string Stage { get; }

        /// <summary>
        /// 0 is first
        /// </summary>
        public int Order { get; }

        public IEnumerator<IStepPhase> GetEnumerator() => _value.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => _value.GetEnumerator();
    }
}
