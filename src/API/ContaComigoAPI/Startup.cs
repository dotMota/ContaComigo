using ContaComigoAPI.Services;
using ContaComigoAPI.Models;
using ContaComigoAPI.Controllers;
using Microsoft.OpenApi.Models;
using ContaComigoAPI.Interfaces;

namespace ContaComigoAPI
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // Registro dos serviços
            services.AddScoped<IUserService, UserServices>(); // Corrigido o nome do serviço aqui
            services.AddScoped<IExpenseService, ExpenseServices>();

            // Configuração do Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ContaComigoAPI", Version = "v1" });
            });

            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ContaComigoAPI v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
