using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using LunchSystem.Models;
using LunchSystem.Models.Interfaces;

namespace LunchSystem
{
    public class AutofacConfig
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly).PropertiesAutowired();
            builder.RegisterType<OrderManager>().As<IOrderManager>().SingleInstance();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}