using System;
// ReSharper disable CheckNamespace

namespace Blacklite
{
    public interface IServicesContext
    {
        IServiceProvider ServiceProvider { get; }
    }
}
