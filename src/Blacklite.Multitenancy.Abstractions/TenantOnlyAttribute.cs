using System;

namespace Blacklite.Multitenancy
{
    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Class)]
    public class TenantOnlyAttribute : Attribute { }
}
