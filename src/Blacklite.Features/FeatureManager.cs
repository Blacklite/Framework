﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Diagnostics;
using Blacklite.Features.Describers;
using Blacklite.Features.Repositories;
using Blacklite.Features.Observables;

namespace Blacklite.Features
{
    public class FeatureManager : IFeatureManager
    {
        private readonly IFeatureRepositoryProvider _repositoryProvider;
        private readonly IFeatureSubjectFactory _subjectFactory;

        public FeatureManager(IFeatureRepositoryProvider repositoryProvider, IFeatureSubjectFactory subjectFactory)
        {
            _repositoryProvider = repositoryProvider;
            _subjectFactory = subjectFactory;
        }

        public bool TrySaveFeature(IFeatureDescriber describer, IFeature feature)
        {
            var result = false;
            var repository = _repositoryProvider.GetFeatureRepository(describer);
            if (repository != null)
            {
                repository.Store(feature, describer);
                result = true;
            }

            if (describer.IsObservable)
            {
                var subject = _subjectFactory.GetSubject(describer.Type);
                subject.Update();
            }

            return result;
        }
    }
}
