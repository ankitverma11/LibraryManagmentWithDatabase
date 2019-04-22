using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagment.Data;
using LibraryManagment.Data.Interfaces;
using LibraryManagment.Data.Repository;
using LibraryManagmentWithDB.Data.DataContext;
using LibraryManagmentWithDB.Healper;
using LibraryManagmentWithDB.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace LibraryManagment
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
            services.AddMvc();
            // For dependecy injection we need to add dbcontext class in the staup class file
            services.AddDbContext<LibraryDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("LibraryDBContext"))); 

           
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IAuthorRepository, AuthorRepository>();
            //Transient objects are always different; a new instance is provided to every controller and every service.
            //Transient objects are always different; a new instance is provided to every controller and every service.
            services.AddTransient<IBookRepository, BookRepository>();
           
            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSetting>(appSettingsSection);
            var appSettings = appSettingsSection.Get<AppSetting>();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });
            services.AddScoped<IUserService, UserService>();



            // Singleton objects are the same for every object and every request.
            //which creates a single instance throughout the application. It creates the instance for the first time and reuses the same object in the all calls.
            //services.AddSingleton<IBookRepository, BookRepository>();

            //Scoped objects are the same within a request, but different across different requests
            //Scoped lifetime services are created once per request within the scope. It is equivalent to Singleton in the current scope. 
            //eg. in MVC it creates 1 instance per each http request but uses the same instance in the other calls within the same web request.
            //services.AddScoped<IBookRepository, BookRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            //app.UseAuthentication(); // to naviage login 
            app.UseAuthentication();

            //app.UseMvc();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
