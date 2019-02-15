using Autofac;
using Autofac.Integration.Mvc;
using NTierMvc.BLL;
using NTierMvc.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NTierMvc.App_Start
{
    public class DependencyConfig
    {
        public static void ConfigContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterFilterProvider();
            builder.RegisterSource(new ViewRegistrationSource());
            builder.RegisterType<NTierMvcDBEntities>().InstancePerRequest();

            builder.RegisterType<EmployeeService>().As<IEmployee>();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}