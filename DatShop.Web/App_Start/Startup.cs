using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using DatShop.Data;
using DatShop.Data.Infrastructure;
using DatShop.Data.Repository;
using DatShop.Service;
using Microsoft.Owin;
using Owin;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;

[assembly: OwinStartup(typeof(DatShop.Web.Startup))]

namespace DatShop.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigAutofac(app);
        }

        private void ConfigAutofac(IAppBuilder app)
        {
            var builder = new ContainerBuilder();
            //Register controller
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            //Register webapi
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

            builder.RegisterType<DatShopDbContext>().AsSelf().InstancePerRequest();
            //Repository
            builder.RegisterAssemblyTypes(typeof(PostCatagoryRepository).Assembly)
                .Where(t => t.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerRequest();



            //Service
            builder.RegisterAssemblyTypes(typeof(PostCatagoryService).Assembly)
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces().InstancePerRequest();

            Autofac.IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container);
        }
    }
}