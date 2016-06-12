using MediatR;

namespace Blacklite.Domain.Process.Requests
{
    public interface ISaveRequest<out T, out TResponse> : ICancellableAsyncRequest<TResponse>
        where TResponse : IResponse<T>
    {
        T Input { get; }
    }

    public class SaveRequest<T, TResponse> : ISaveRequest<T, TResponse>
        where TResponse : IResponse<T>
    {
        public SaveRequest(T instance)
        {
            Input = instance;
        }

        public T Input { get; }
    }
}
