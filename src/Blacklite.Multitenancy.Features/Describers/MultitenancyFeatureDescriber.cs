using Blacklite.Features;
using Blacklite.Features.Describers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;

namespace Blacklite.Multitenancy.Features.Describers
{
    public class MultitenancyFeatureDescriber : FeatureDescriber
    {
        public MultitenancyFeatureDescriber(TypeInfo typeInfo)
            : base(typeInfo)
        {
            IsApplicationScoped = TypeInfo.GetCustomAttributes<ApplicationOnlyAttribute>().Any();
            IsTenantScoped = TypeInfo.GetCustomAttributes<TenantOnlyAttribute>().Any();
        }

        public bool IsTenantScoped { get; }

        public bool IsApplicationScoped { get; }
    }
}
