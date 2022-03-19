using Financial.CrossCutting.Solvers.DataBase;
using Financial.Data.Repositories;
using Financial.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Financial.CrossCutting.Solvers
{
    public static class ConfigureRepositories
    {
        public static void DependencyInjection(IServiceCollection service)
        {
            service.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            service.AddScoped<IMySqlDataBase, MySqlDataBase>();
        }
    }
}
