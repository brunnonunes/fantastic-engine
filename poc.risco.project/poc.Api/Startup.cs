using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using poc.Core.ConfigurationSettings;
using poc.Core.Interfaces.Repositories;
using poc.Core.Interfaces.Services;
using poc.Core.Services;
using poc.Infra.Repositories;

namespace poc.Api {

    public class Startup {

        public IConfiguration Configuration { get; }

        public Startup(IHostingEnvironment env, IConfiguration configuration) { Configuration = configuration; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) {

            services.AddMvc();

            services.Configure<GimSettings>(Configuration.GetSection("GimSettings"));

            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserRepository, UserRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env) {

            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
