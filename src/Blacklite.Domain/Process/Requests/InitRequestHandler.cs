using Blacklite.Domain.Process.Steps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Blacklite.Domain.Process.Requests
{
    public interface IInitRequestHandler<T, in TRequest, TResponse> : IRequestHandler<T, TRequest, TResponse>
        where TRequest : IInitRequest<T, TResponse>
        where TResponse : IResponse<T>
    {

    }

    public class InitRequestHandler<T, TRequest, TResponse> : RequestHandler<T, TRequest, TResponse>, IInitRequestHandler<T, TRequest, TResponse>
        where TRequest : IInitRequest<T, TResponse>
        where TResponse : IResponse<T>
    {
        public InitRequestHandler(
            IDomainStepProvider stepProvider,
            IServiceProvider serviceProvider,
            TResponse response)
            : base(stepProvider, serviceProvider, response)
        {
        }

        public override Task<TResponse> Handle(TRequest message, CancellationToken token)
        {
            // Get the steps for the stage
            var phases = StepProvider.GetStepsForStage(nameof(Phases.Init), typeof(T));

            var validations = new List<IValidation>();
            Response.Errors = validations;

            // Each phase runs sequentially
            foreach (var phase in phases)
            {
                foreach (var descriptor in phase)
                {
                    validations.AddRange(descriptor.Execute(ServiceProvider, null));
                }

                // If a phase encounters errors, the request is aborted, and the errors returned.
                if (validations.Any())
                {
                    Response.Result = default(T);
                    break;
                }
            }

            // Success is decied by if there were any errors or not.
            Response.Success = !validations.Any();

            if (Response.Success)
                Response.Result = message.Input;

            return Task.FromResult(Response);
        }
    }
}
