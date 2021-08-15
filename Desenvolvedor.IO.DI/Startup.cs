using System;
using Desenvolvedor.IO.DI.Cases;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Desenvolvedor.IO.DI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            #region Lifecycle

            services.AddTransient<IOperacaoTransient, Operacao>();
            services.AddScoped<IOperacaoScoped, Operacao>();
            services.AddSingleton<IOperacaoSingleton, Operacao>();
            services.AddSingleton<IOperacaoSingletonInstance>(new Operacao(Guid.Empty));
            services.AddTransient<OperacaoService>();

            #endregion

            #region VidaReal

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IClienteServices, ClienteServices>();

            #endregion

            #region Generics

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            #endregion

            #region MultiplasClasses

            services.AddTransient<ServiceA>();
            services.AddTransient<ServiceB>();
            services.AddTransient<ServiceC>();
            services.AddTransient<Func<string, IService>>(serviceProvider => key =>
            {
                return key switch
                {
                    "A" => serviceProvider.GetService<ServiceA>(),
                    "B" => serviceProvider.GetService<ServiceB>(),
                    "C" => serviceProvider.GetService<ServiceC>(),
                    _ => null,
                };
            });

            #endregion

            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints => endpoints.MapRazorPages());
        }
    }
}
