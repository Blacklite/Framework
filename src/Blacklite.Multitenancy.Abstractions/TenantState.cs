using System;

namespace Blacklite.Multitenancy
{
    public enum TenantState
    {
        None,
        Boot,
        Started,
        Stopped,
        Shutdown
    }
}
