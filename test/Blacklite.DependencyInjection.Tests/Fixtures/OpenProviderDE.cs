﻿using Microsoft.Extensions.DependencyInjection;
using System;

namespace DependencyInjection.Tests.Fixtures
{
    public interface IOpenProviderD<T>
    {
        int ItemA { get; }
    }

    public interface IOpenProviderE<T>
    {
        decimal ItemB { get; }
    }

    public interface IOpenProviderF<T>
    {
        T Value { get; }
    }

    [ServiceDescriptor(Lifetime = ServiceLifetime.Scoped)]
    class OpenProviderDE<T> : IOpenProviderD<T>, IOpenProviderE<T>, IOpenProviderF<string>
    {
        public int ItemA
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public decimal ItemB
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Value
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
