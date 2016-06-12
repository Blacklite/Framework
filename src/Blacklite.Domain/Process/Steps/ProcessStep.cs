using Blacklite.Domain.Steps;

namespace Blacklite.Domain.Process.Steps
{
    public interface IProcessStep : IPhasedStep
    {

    }

    public abstract class ProcessStep<T> : PhasedStep<T>, IProcessStep where T : class { }
}
