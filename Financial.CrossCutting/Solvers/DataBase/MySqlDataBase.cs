using Financial.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Financial.CrossCutting.Solvers.DataBase
{
    public class MySqlDataBase : IMySqlDataBase
    {
        public static string MY_SQL_CONNECTION { get; set; }

        public void IncludeDataBase(IServiceCollection service)
        {
            service.AddDbContext<MyContext>(options => options.UseMySql(MY_SQL_CONNECTION, ServerVersion.Parse("5.7-mysql"),
                            options => options.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null)));
        }
    }
}
