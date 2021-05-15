using Catharsium.Templates.ClassLibrary._Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace Catharsium.Templates.ClassLibrary.Tests._Configuration
{
    [TestClass]
    public class RegistrationTests
    {
        [TestMethod]
        public void AddCatharsiumProjectClassName_RegistersDependencies()
        {
            var serviceCollection = Substitute.For<IServiceCollection>();
            var configuration = Substitute.For<IConfiguration>();

            serviceCollection.AddCatharsiumProjectClassName(configuration);
        }


        [TestMethod]
        public void AddCatharsiumProjectClassName_RegistersPackages()
        {
            var serviceCollection = Substitute.For<IServiceCollection>();
            var configuration = Substitute.For<IConfiguration>();

            serviceCollection.AddCatharsiumProjectClassName(configuration);
        }
    }
}