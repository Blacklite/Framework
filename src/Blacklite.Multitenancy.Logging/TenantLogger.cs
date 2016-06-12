using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace Blacklite.Multitenancy
{
    class TenantLogger : ITenantLogger
    {
        private ILogger _logger;
        public TenantLogger([NotNull] ITenant tenant, [NotNull] ILoggerFactory factory)
        {
            _logger = factory.CreateLogger(tenant.Id ?? "Tenant");
        }

        public IDisposable BeginScopeImpl(object state)
        {
            return _logger.BeginScopeImpl(state);
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return _logger.IsEnabled(logLevel);
        }

        public void Log(LogLevel logLevel, int eventId, object state, Exception exception, Func<object, Exception, string> formatter)
        {
            _logger.Log(logLevel, eventId, state, exception, formatter);
        }
    }
}
