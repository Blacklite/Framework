using System.Collections.Generic;

namespace Blacklite.Domain.Process.Requests
{
    public interface IResponse
    {
        bool Success { get; set; }
    }

    public interface IResponse<T> : IResponse
    {
        T Result { get; set; }
        IEnumerable<IValidation> Errors { get; set; }
    }

    public class Response<T> : IResponse<T>
    {
        public T Result { get; set; }
        public IEnumerable<IValidation> Errors { get; set; }
        public bool Success { get; set; }
    }
}
