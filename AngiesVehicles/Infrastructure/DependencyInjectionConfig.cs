using AngiesVehicles.Dal;
using AngiesVehicles.Helpers;
using AngiesVehicles.Models;
using AngiesVehicles.Services;
using Autofac;
using Autofac.Integration.Mvc;
using ConnexusCommon.Services.Base.Classes;
using ConnexusComponents.Logging;
using System.Reflection;
using System.Web.Mvc;

namespace AngiesVehicles.Infrastructure
{
    public class DependencyInjectionConfig
    {
        /// <summary>
        /// Registers all dependencies for the application
        /// </summary>
        public static void RegisterDependencies()
        {
            #region Container creation

            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());


            #endregion

            builder.Register((CTX) => GetExceptionHelperInstance());

            builder.RegisterType<AngiesVehiclesDbContext>().As<IAngiesVehiclesDbContext>();
            builder.RegisterType<InventoryService>().As<IInventoryService>();
            builder.RegisterType<InventoryHelper>().As<IInventoryHelper>();


            #region Resolve container

            var container = builder.Build();
            var dependencyResolver = new AutofacDependencyResolver(container);
            DependencyResolver.SetResolver(dependencyResolver);

            #endregion
        }

        /// <summary>
        /// Gets an instance of the <see cref="ExceptionHelper"/> class, preconfigured with NLog logging
        /// </summary>
        private static ExceptionHelper GetExceptionHelperInstance()
        {
            return ExceptionHelperFactory.GetInstance(ProviderExtensions.UnitTesting);
        }
    }
}