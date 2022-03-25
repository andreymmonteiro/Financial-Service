using Financial.Domain.Mapper.Interface;
using Financial.Domain.Services;
using Financial.Service;
using Financial.Service.AutoMapperConfigure;
using Microsoft.Extensions.DependencyInjection;

namespace Financial.CrossCutting.Solvers
{
    public static class ConfigureLocalServices
    {
        public static void DependencyInjection(IServiceCollection service)
        {
            service.AddSingleton<IMapperService, AutoMapperFixtureService>();
            service.AddScoped<IFinanceAccountsService, FinanceAccountsService>();
            service.AddScoped<IPaymentTermsService, PaymentTermsService>();
        }
    }
}
