using System;
using System.Reflection;

namespace Blacklite.Domain.Steps
{
    // Defines a "Step" of the process, that is a small isolated unit of work.
    //
    // Every step must implement this interface plus two methods:
    //
    // bool CanExecute(object|T instance[, IStepContext context]);
    //
    // Basically the CanExecute method, can either take a "object", or it can be specificly
    //     implemented to take a specific type like the Step generic class does.
    //
    // void|IEnumerable[IValidation] Execute(object|T instance[, IStepContext context[, ... Any interface that IServiceProvider can resolve]]);
    //
    // The execute method is "Injectable" this means that you can add any value you want onto it that you can possibly imagine.  These values are all serviced through the service provider interface.
    // In addition there are two special params, the object instance, and IStepContext, which gets the process context used for this request.
    //     Both of these special params can be more specificly typed as appropriate, but if the type is wrong you'll run into errors are runtime.
    public interface IStep
    {
        bool CanRun([NotNull] Type type);
        bool CanExecute(object instance);
    }

    /// <summary>
    /// A generic step interface that implements a Typed version of CanExecute, and filters the step based on the Type of T.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Step<T> : IStep
        where T : class
    {
        public virtual bool CanExecute(T instance) => true;

        public virtual bool CanRun(Type type) => typeof(T).GetTypeInfo().IsAssignableFrom(type.GetTypeInfo());

        bool IStep.CanExecute(object instance) => CanExecute((T)instance);
    }
}
