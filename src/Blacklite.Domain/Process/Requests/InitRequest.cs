using MediatR;

namespace Blacklite.Domain.Process.Requests
{
    public interface IInitRequest<out T, out TResponse> : ICancellableAsyncRequest<TResponse>
        where TResponse : IResponse<T>
    {
    }

    public abstract class InitRequest<T, TResponse> : IInitRequest<T, TResponse>
        where TResponse : IResponse<T>
    {
    }
}
