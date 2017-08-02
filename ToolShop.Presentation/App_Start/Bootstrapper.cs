using Autofac;
using Autofac.Integration.Mvc;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using ToolShop.DataStore.Infrastructure;
using ToolShop.DataStore.Repositories;
using ToolShop.Presentation.Mappings;
using ToolShop.Services.Services;

namespace ToolShop.Presentation
{
    public class Bootstrapper
    {
        /// <summary>
        /// Run the bootstrapper to load dependency injection, mappers and other utilities
        /// </summary>
        public static void Run()
        {
            AutoMapperConfiguration.Configure();
            SetAutofacMapper();
        }

        /// <summary>
        /// Initialize the Autofac registrations
        /// </summary>
        private static void SetAutofacMapper()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

            builder.RegisterAssemblyTypes(typeof(CategoryRepository).Assembly)
                .Where(x => x.Name.Contains("Repository"))
                .AsImplementedInterfaces()
                .InstancePerRequest();

            builder.RegisterAssemblyTypes(typeof(CategoryService).Assembly)
                .Where(x => x.Name.Contains("Service"))
                .AsImplementedInterfaces()
                .InstancePerRequest();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}