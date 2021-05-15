﻿using Catharsium.Templates.ClassLibrary._Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace Catharsium.Templates.ClassLibrary.Tests._Configuration
{
    [TestClass]
    public class CatharsiumProjectClassNameRegistrationTests
    {
        [TestMethod]
        public void AddProject_RegistersDependencies()
        {
            var serviceCollection = Substitute.For<IServiceCollection>();
            var configuration = Substitute.For<IConfiguration>();

            serviceCollection.AddUnitTests(configuration);
        }


        [TestMethod]
        public void AddProject_RegistersPackages()
        {
            var serviceCollection = Substitute.For<IServiceCollection>();
            var configuration = Substitute.For<IConfiguration>();

            serviceCollection.AddUnitTests(configuration);
        }
    }
}