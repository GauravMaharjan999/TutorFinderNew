 using ClientNotifications;
using ClientNotifications.ServiceExtensions;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Modellayer.Models;
using BusinessLayer.BaseRepository;
using BusinessLayer.StudentLogics;
using BusinessLayer.ClassLogics;
using BusinessLayer.HelperTools;
using BusinessLayer.EmailSenderLogics;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.SignalR;

namespace StudentManagement
{
    public class Startup
    {
        private IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
  

        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddDbContextPool<AppDbContext>(
                options => options.UseSqlServer(_config.GetConnectionString("EmployeeDBConnection")));



            services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 3;
                options.Password.RequiredUniqueChars = 0;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
            }).AddEntityFrameworkStores<AppDbContext>();


            //To apply [Authorize] attribute globally on all controllers
            /*  services.AddMvc(config => {
                  var policy = new AuthorizationPolicyBuilder()
                                  .RequireAuthenticatedUser()
                                  .Build();
                  config.Filters.Add(new AuthorizeFilter(policy));
              });*/


            var emailConfig = _config
                .GetSection("EmailConfiguration")
                .Get<EmailConfiguration>();
            services.AddSingleton(emailConfig);

            services.Configure<FormOptions>(o => {
                o.ValueLengthLimit = int.MaxValue;
                o.MultipartBodyLengthLimit = int.MaxValue;
                o.MemoryBufferThreshold = int.MaxValue;
            });


            services.AddMvc();

            // Add SignalR here:
            services.AddSignalR();
            services.AddToastNotification();
            services.AddScoped<IEmployeeRepositary, MockEmployeeRepositary>();
            services.AddTransient<ICourseBL, CourseBL>();
            services.AddTransient<IBaseRepository, BaseRepository>();
            services.AddScoped<IHelperTool, HelperTool>();
            services.AddScoped<IClientNotification, ClientNotification>();
            services.AddScoped<IClassBL, ClassBL>();
            services.AddScoped<IEmailSender, EmailSender>();
            services.AddScoped<ICourseBL, CourseBL>();
            services.AddScoped<IStudentRecordBL, StudentRecordBL>();
            services.AddScoped<ITutorBL, TutorBL>();
            services.AddToastNotification();



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                DeveloperExceptionPageOptions developerExceptionPageOptions = new DeveloperExceptionPageOptions
                {
                    SourceCodeLineCount = 10
                };

                app.UseDeveloperExceptionPage();

            }
            app.UseStaticFiles();
            //app.UseMvcWithDefaultRoute();
            app.UseAuthentication();


      
            app.UseMvc(route =>
            {
                
                route.MapRoute(name: "areas",
                    template: "{area:exists}/{controller=home}/{action=index}/{id?}");
                route.MapRoute("Default", "{controller=Home}/{action=Index}/{id?}");
            });
            //// Set up the hub routes here:
            //app.UseSignalR(routes =>
            //{
            //    routes.MapHub<MyHub>("/my");
            //});
        }
    }
}
