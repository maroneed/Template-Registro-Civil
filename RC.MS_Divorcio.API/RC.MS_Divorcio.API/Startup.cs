using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using RC.MS_Divorcio.AccessData;
using RC.MS_Divorcio.AccessData.Commands;
using RC.MS_Divorcio.Application.Services;
using RC.MS_Divorcio.Domain.Commands;
using SqlKata;
using SqlKata.Execution;
using RC.MS_Divorcio.Domain.Queries;
using RC.MS_Divorcio.AccessData.Queries;
using System.Data.SqlClient;
using System.Data;
using SqlKata.Compilers;

namespace RC.MS_Divorcio.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            var connectionString = Configuration.GetSection("connectionString").Value;
            services.AddDbContext<MS_DivorcioDbContext>(options => options.UseSqlServer(connectionString));
            //injectamos el repositorio
            services.AddTransient<IGenericsRepository, GenericsRepository>();
            //injectamos los service
            services.AddTransient<IPropuestaService, PropuestaService>();
            services.AddTransient<ISolicitudTipoService, SolicitudTipoService>();
            services.AddTransient<IHijosService, HijosService>();
            services.AddTransient<IDetalleHijosService, DetalleHijosService>();
            services.AddTransient<IDomicilioConvivenciaService, DomicilioConvivenciaService>();
            services.AddTransient<ITramiteDivorcioService, TramiteDivorcioService>();
            
            //Queries
            services.AddTransient<ITramiteDivorcioQuery, TramiteDivorcioQuery>();



            // SQLKATA
            services.AddTransient<Compiler, SqlServerCompiler>();
            services.AddTransient<IDbConnection>(b =>
            {
                return new SqlConnection(connectionString);
            });



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
