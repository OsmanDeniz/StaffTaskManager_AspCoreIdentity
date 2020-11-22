using Deniz.StaffTaskManager.Businnes.Concrete;
using Deniz.StaffTaskManager.Businnes.Interfaces;
using Deniz.StaffTaskManager.DataAccess.Concrete.EntityFramework.Contexts;
using Deniz.StaffTaskManager.DataAccess.Concrete.EntityFramework.Repositories;
using Deniz.StaffTaskManager.DataAccess.Interfaces;
using Deniz.StaffTaskManager.Entities.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Deniz.StaffTaskManager.WebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            /// Dependecy Injection yapmak icin 
            ///  ITaskService gordugunde TaskManager i ornekle ve kullan diyorum.
            services.AddScoped<ITaskService, TaskManager>();
            services.AddScoped<IUrgencyService, UrgencyManager>();
            services.AddScoped<IReportService, ReportManager>();

            /// DI icin manager icerisinde DAL'lari kullanabilmek icin onlari da  
            /// belirtmem gerekiyor.
            services.AddScoped<ITaskDal, EfTaskRepository>();
            services.AddScoped<IUrgencyDAL, EfUrgencyRepository>();
            services.AddScoped<IReportDAL, EfReportRepository>();

            /// Diger ayarlar,
            /// - DbContext ayari
            /// - Identity ayari = appuser ve approle'u entityframeworke taskcontexti kullanarak ekle
            services.AddDbContext<TaskContext>();
            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<TaskContext>();

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "area",
                    pattern: "{area}/{controller=Home}/{action=Index}/{id?}"
                    );


                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                    );
            });
        }
    }
}
