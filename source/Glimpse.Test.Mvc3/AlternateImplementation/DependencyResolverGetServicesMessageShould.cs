﻿using System;
using System.Linq;
using Glimpse.Mvc.AlternateImplementation;
using Glimpse.Test.Common;
using Xunit;
using Xunit.Extensions;

namespace Glimpse.Test.Mvc3.AlternateImplementation
{
    public class DependencyResolverGetServicesMessageShould
    {
        [Theory, AutoMock]
        public void Construct(Type input)
        {
            var output = new object[] { 1, "a", DateTime.Now };

            var sut = new DependencyResolver.GetServices.Message(input, output);

            Assert.Equal(input, sut.ServiceType);
            Assert.Equal(output.Length, sut.ResolvedTypes.Count());
            Assert.True(sut.IsResolved);
        }

        [Theory, AutoMock]
        public void HandleEmptyOutput(Type input)
        {
            var output = Enumerable.Empty<object>();

            var sut = new DependencyResolver.GetServices.Message(input, output);

            Assert.Equal(input, sut.ServiceType);
            Assert.Null(sut.ResolvedTypes);
            Assert.False(sut.IsResolved);
        }
    }
}