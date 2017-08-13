using Dal;
using Dal.Context;
using Dal.Repositories;
using Dal.Repositories.Interfaces;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Practices.Unity;
using MyHelper.Controllers;
using MyHelper.Models;
using System.Web.Http;
using Unity.WebApi;

namespace MyHelper
{
    /// <summary>
    /// IoC Configuration
    /// </summary>
    public static class UnityConfig
    {
        /// <summary>
        /// Create the IoC Containers
        /// </summary>
        public static UnityContainer RegisterComponents()
        {
			var container = new UnityContainer();

            // Context injection with lifetimemager and database connectionstring name
            container.RegisterType<IHelperContext, LilHelperEntities>(
                new TransientLifetimeManager(),
                new InjectionConstructor("LilHelperEntities"));

            // Repositories
            container.RegisterType<IInventarRepository, InventarRepository>();
            container.RegisterType<IUserRepository, UserRepository>();

            // Services
            container.RegisterType<AccountController>(new InjectionConstructor());

            // GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);

            return container;
        }
    }
}