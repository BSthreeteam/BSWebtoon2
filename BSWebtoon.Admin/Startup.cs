using BSWebtoon.Admin.IDapperRepository;
using BSWebtoon.Admin.Service.AdminComicCloudinaryService;
using BSWebtoon.Admin.Service.AdminUploadComicService;
using BSWebtoon.Admin.Service.JobService;
using BSWebtoon.Model.Models;
using Coravel;
using BSWebtoon.Admin.Service.ActivityService;

using BSWebtoon.Model.Repository;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BSWebtoon.Admin.Service.CloudinaryService;

namespace BSWebtoon.Admin
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
            services.AddControllersWithViews();
           
            //加以下這段
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    //設定登入Action的路徑： 
                    options.LoginPath = new PathString("/Home/Login");

                    //設定 導回網址 的QueryString參數名稱：
                    options.ReturnUrlParameter = "ReturnUrl";

                    //設定登出Action的路徑： 
                    options.LogoutPath = new PathString("/Home/Logout");

                });
            //....AuthenticationScheme其實只是個字串 "Cookies"，改成其他字串也未嘗不可
            //記得自行引入命名空間，後續不再不多提。

            services.AddDbContext<BSWebtoonDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("BSWebtoonDbContext")));


            services.AddTransient<IDapperEmployeeRepository, DapperEmployeeRepository>();
            services.AddTransient<IDapperMemberRepository, DapperMemberRepository>();

            services.AddTransient<IDapperDashActivityRepository, DapperDashActivityRepository>();
            services.AddTransient<IDapperDashMemberRepository, DapperDashMemberRepository>();
            services.AddTransient<IDapperDashRankRepository, DapperDashRankRepository>();
            services.AddTransient<IDapperDashComicRepository, DapperDashComicRepository>();

            services.AddTransient<IDapperActivityRepository, DapperActivityRepository>();
            //活動
            services.AddScoped<IActivityService, ActivityService>();
            //註冊
            services.AddScoped<BSRepository, BSRepository>();

            //註冊
            services.AddScoped<ICloudinaryService, CloudinaryService>();


            //services.AddTransient<IDapperActivityRepository, DapperActivityRepository>();


            services.AddTransient<IDapperCouponUseRecordRepository, DapperCouponUseRecordRepository>();
            services.AddTransient<IDapperCouponRepository, DapperCouponRepository>();


            services.AddTransient<IAdminUploadComicService, AdminUploadComicService>();
            services.AddTransient<IAdminComicCloudinaryService, AdminComicCloudinaryService>();



            //加Dapper註冊
            services.AddScoped<IDbConnection, SqlConnection>(serviceProvider =>
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = Configuration.GetConnectionString("BSWebtoonDbContext");
                return conn;
            });

            //記得註冊 Invocable的實作
            services.AddTransient<ActivityIsDelete>();
            services.AddTransient<CountDownCoupon>();

            //這一定要有
            services.AddScheduler();

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", policy =>
                {
                    policy.AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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

            app.ApplicationServices.UseScheduler(scheduler =>
            {
                scheduler.Schedule<ActivityIsDelete>().Daily().RunOnceAtStart();
                scheduler.Schedule<CountDownCoupon>().Hourly().RunOnceAtStart();
            });

            app.UseHttpsRedirection();
            app.UseCors("CorsPolicy");

            app.UseRouting();
            app.UseAuthentication();

            app.UseAuthentication();//加這句
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
