using Autofac;
using Template.Logic;
using Template.Logic.Interface;
using Template.Service;
using Template.Service.Interface;

namespace Template.Dependency
{
    public class DependencyInjectionConfig
    {
        public static void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterType<ClientLogic>().As<IClientLogic>();
            builder.RegisterType<ClientService>().As<IClientService>();
        }
    }
}
