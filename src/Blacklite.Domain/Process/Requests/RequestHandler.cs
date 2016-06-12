using Blacklite.Domain.Process.Steps;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace Blacklite.Domain.Process.Requests
{
    public interface IRequestHandler<T, in TRequest, TResponse> : ICancellableAsyncRequestHandler<TRequest, TResponse>
        where TRequest : ICancellableAsyncRequest<TResponse>
        where TResponse : IResponse<T>
    {

    }

    public abstract class RequestHandler<T, TRequest, TResponse> : IRequestHandler<T, TRequest, TResponse>
        where TRequest : ICancellableAsyncRequest<TResponse>
        where TResponse : IResponse<T>
    {
        protected IDomainStepProvider StepProvider { get; }
        protected IServiceProvider ServiceProvider { get; }
        protected TResponse Response { get; }

        protected RequestHandler(
            IDomainStepProvider stepProvider,
            IServiceProvider serviceProvider,
            TResponse response)
        {
            StepProvider = stepProvider;
            ServiceProvider = serviceProvider;
            Response = response;
        }

        public abstract Task<TResponse> Handle(TRequest message, CancellationToken token);
    }

}
