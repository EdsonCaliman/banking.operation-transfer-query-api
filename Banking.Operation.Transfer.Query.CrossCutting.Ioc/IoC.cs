using Banking.Operation.Transfer.Query.CrossCutting.Ioc.Modules;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Net.Core.Template.CrossCutting.Ioc.Modules;

namespace Net.Core.Template.CrossCutting.Ioc
{
    public static class IoC
    {
        public static IServiceCollection ConfigureContainer(this IServiceCollection services, IConfiguration configuration)
        {
            MongoDbModule.Register(services, configuration);
            services.Register();
            return services;
        }
    }
}