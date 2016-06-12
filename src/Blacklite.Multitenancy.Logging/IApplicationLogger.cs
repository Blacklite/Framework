using Microsoft.Extensions.Logging;
using System;

namespace Blacklite.Multitenancy
{
    [ApplicationOnly]
    public interface IApplicationLogger : ILogger { }
}
