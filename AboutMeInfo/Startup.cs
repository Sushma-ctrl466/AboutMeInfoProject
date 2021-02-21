using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleInjector;
using AboutMe.Domain.Abstract.Repositories.RepoInterface;
using AboutMe.Domain.Abstract.Repositories.BusinessInterface;
using AboutMe.Infrastructure.Repo;
using AboutMe.Domain.BusinessEntity;
using System.Web.Mvc;

namespace AboutMeInfo
{
    public class Startup
    {
        private Container container = new Container();
        public Startup(IConfiguration configuration)
        {
            container.Options.ResolveUnregisteredConcreteTypes = false;
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();            
            services.AddSingleton(container);
            InitializeContainer();
        }
        private void InitializeContainer()
        {
            container.Register<AboutMeRepoInterface, AboutMeRepo>();
            container.Register<AboutMeBusinessInterface, AboutMeBusinessEntity>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //app.UseSimpleInjector(container);

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
