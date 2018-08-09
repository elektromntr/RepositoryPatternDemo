using Autofac.Integration.Mvc;
using Data;
using Service;
using System.Reflection;
using System.Web.Mvc;

namespace Web
{
    public static Run()
    {
        SetAutofacContainer();
    }

    private static void SetAutofacContainer()
    {
        var builder = new ContainerBuilder();
        builder.RegisterControllers(Assembly.GetExecutingAssembly());
        builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
        builder.RegisterType<DbFactory>().As<IDbFactory>().InstancePerRequest();

        //Repositories
        builder.RegisterAssemblyTypes(typeof(HeroRepository).Assembly)
            .Where(t => t.Name.EndsWith("Repository"))
            .AsImplementedInterfaces().InstancePerRequest();

        //Services
        builder.RegisterAssemblyTypes(typeof(HeroService).Assembly)
            .Where(t => t.Name.EndsWith("Service"))
            .AsImplementedInterfaces().InstancePerRequest();

        IContainer container = builder.Build();
        DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

    }
}

