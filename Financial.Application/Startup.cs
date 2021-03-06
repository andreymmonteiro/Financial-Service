using Financial.Aplpication.Mapper.ConfigureAutoMapper.Interface;
using Financial.Application.Mapper.ConfigureAutoMapper;
using Financial.Application.Services;
using Financial.CrossCutting.Solvers;
using Financial.Domain.Models.DataBase;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Financial.Application
{
    public class Startup
    {
        //Will be create a json config to define
        private const string MY_SQL_DATA_BASE_CONNECTION = "DataBase:MySql:ConnectionString";
        private readonly IConfiguration Configuration;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddGrpc();
            services.AddScoped<IMapperProtoService, AutoMapperFixtureProtoService>();

            ConfigureRepositories.DependencyInjection(services);
            ConfigureLocalServices.DependencyInjection(services);

            string mySql = Configuration.GetSection(MY_SQL_DATA_BASE_CONNECTION).Value.ToString();
            if (!string.IsNullOrWhiteSpace(mySql))
            {
                services.IncludeDataBase(DataBaseType.mySql, mySql);
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGrpcService<FinanceAccountsApplicationProtoService>();

                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");
                });
            });
        }
    }
}
