using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClinicManagementProject.Models;
using ClinicManagementProject.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ClinicManagementProject
{
    public class Startup
    {
        public IConfiguration Configuration { get; private set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<ClinicManagementContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:companyCon"]));
            services.AddScoped<IRepo<Patient, string>, PatientRepo>();
            services.AddScoped<IRepo<Doctor, string>, DoctorRepo>();
            services.AddScoped<IRepo<DoctorSchedule, List<int>>, DoctorScheduleRepo>();
            services.AddScoped<ILoginService<PatientViewModel, string>, PatientLoginService>();
            services.AddScoped<ILoginService<DoctorViewModel, string>, DoctorLoginService>();
            services.AddScoped<IRepo<ConsultationDetail, List<int>>, ConsultationDetailRepo>();
            //services.AddScoped<IRepo<ConsultationDetail, List<int>>, ConsultationUpdateRepo>();


            //services.AddScoped<PatientLoginService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{Controller=Home}/{Action=Index}/{Id?}");
            });
        }
    }
}
