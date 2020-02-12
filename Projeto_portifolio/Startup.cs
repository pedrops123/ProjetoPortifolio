using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SmartBreadcrumbs.Extensions;

namespace ProjetoPortifolio
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

            services.AddBreadcrumbs(GetType().Assembly, options =>
            {
                options.TagName = "div";
                options.DontLookForDefaultNode = true;
                options.TagClasses = "";
                options.OlClasses = "breadcrumb";
                options.LiClasses = "breadcrumb-item";
                options.ActiveLiClasses = "breadcrumb-item active";
                options.SeparatorElement = "<li class=\"separator\">&nbsp/&nbsp</li>";
            });

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.ConfigureApplicationCookie(options =>
            {
                options.AccessDeniedPath = new PathString("/managerlogin/login");
                options.Cookie.Name = "Cookie_port";
                options.Cookie.HttpOnly = true;
                //  options.ExpireTimeSpan = TimeSpan.FromMinutes(720);
                options.LoginPath = "/managerlogin/login";
                options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
                options.SlidingExpiration = true;

            });

            services.AddAuthentication("FiverSecurityScheme")
             .AddCookie("FiverSecurityScheme", options =>
             {
                 options.AccessDeniedPath = new PathString(@"/managerlogin/login");
                 options.LoginPath = new PathString(@"/managerlogin/login");
             });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);




        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseCookiePolicy();
            app.UseMvc(routes =>
            {

                // Rota Paginas gerais Criadas 
                routes.MapRoute(
                    name: "Portifolio",
                    template: "{controller}/pagina/{pagina}/{*nomeTela}",
                    defaults: new { controller = "Portifolio", action = "ChamaViewDinamica" });

                // Rota Login
                routes.MapRoute(
                        name: "login",
                        template: "managerlogin/login",
                        defaults: new { controller = "LoginLogout", action = "Index" });


                // Rota Valida Login
                routes.MapRoute(
                    name: "validaUser",
                    template: "managerlogin/validaUser",
                    defaults: new { controller = "LoginLogout", action = "loginManager" });


                // Rota Logout 
                routes.MapRoute(
                    name: "logout",
                    template: "managerlogin/logout",
                    defaults: new { controller = "LoginLogout", action = "logout" });

                // Rota Manager Principal
                routes.MapRoute(
                    name: "managerPrincipal",
                    template: "{controller}/manager_principal",
                    defaults: new { controller = "Portifolio", action = "chamaManagerPrincipal" });

                // Rota cadastro paginas
                routes.MapRoute(
                   name: "cadastroPaginas",
                   template: "{controller}/ConfiguracaoPagina/{*tagPagina}",
                   defaults: new { controller = "Portifolio", action = "DadosTelaDinamicoManager" });

                //routes.MapRoute("PortifolioPedro", "{controller=Portifolio}/{action=PortifolioPedro}/{id?}");
                //routes.MapRoute("Login", "{controller=Portifolio}/{action=Login}/{id?}");

                // Rota padrão default
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Portifolio}/{action=ChamaViewDinamica}/{id?}"
                    );
            });
        }
    }
}
