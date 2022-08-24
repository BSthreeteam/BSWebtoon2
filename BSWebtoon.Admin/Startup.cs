using BSWebtoon.Admin.IDapperRepository;
using BSWebtoon.Admin.Service.AdminComicCloudinaryService;
using BSWebtoon.Admin.Service.AdminUploadComicService;
using BSWebtoon.Admin.Service.JobService;
using BSWebtoon.Model.Models;
using Coravel;
using BSWebtoon.Admin.Service.ActivityService;

using BSWebtoon.Model.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
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
            services.AddTransient<IDapperUpdateComicStatusRepository, DapperUpdateComicStatusRepository>();
            services.AddTransient<IDapperEpisodeRepository, DapperEpisodeRepository>();


            services.AddTransient<IAdminUploadComicService, AdminUploadComicService>();
            services.AddTransient<IAdminComicCloudinaryService, AdminComicCloudinaryService>();



            //加Dapper註冊
            services.AddScoped<IDbConnection, SqlConnection>(serviceProvider =>
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = Configuration.GetConnectionString("BSWebtoonDbContext");
                return conn;
            });

            //註冊 Invocable的實作
            services.AddTransient<ActivityIsDelete>();
            services.AddTransient<CountDownCoupon>();
            services.AddTransient<NewWorkToSerialize>();
            services.AddTransient<LastFiveEpIsNotCountdown>();

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
                scheduler.Schedule<ActivityIsDelete>().DailyAtHour(0);
                scheduler.Schedule<CountDownCoupon>().HourlyAt(0);
                scheduler.Schedule<NewWorkToSerialize>().DailyAtHour(0);
                scheduler.Schedule<LastFiveEpIsNotCountdown>().DailyAtHour(0);
            });

            app.UseHttpsRedirection();
            app.UseCors("CorsPolicy");

            app.UseRouting();

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
