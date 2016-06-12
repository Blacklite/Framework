using System;
using Blacklite.Events;

namespace Blacklite.Multitenancy
{
    public interface ITenantEvent : IEvent
    {
        string Tenant { get; }
    }
}
