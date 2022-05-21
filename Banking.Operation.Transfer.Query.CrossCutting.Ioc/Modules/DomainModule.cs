using Banking.Operation.Transfer.Query.Domain.Tranfers.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Net.Core.Template.CrossCutting.Ioc.Modules
{
    public static class DomainModule
    {
        public static void Register(this IServiceCollection services)
        {
            services.AddScoped<ITransferService, TransferService>();
        }
    }
}