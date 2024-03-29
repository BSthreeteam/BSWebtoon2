using BSWebtoon.Front.Service;
using BSWebtoon.Front.Service.CouponService;
using BSWebtoon.Front.Service.EmployeeService;
using BSWebtoon.Front.Service.RechargeService;
using BSWebtoon.Front.Service.ComicService;
using BSWebtoon.Front.Service.FavoriteService;
using BSWebtoon.Front.Service.MemberService;
using BSWebtoon.Front.Service.RecommendService;
using BSWebtoon.Model.Models;
using BSWebtoon.Model.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BSWebtoon.Front.Service.RankService;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using BSWebtoon.Front.Service.WeekUpdateService;
using BSWebtoon.Front.Service.SearchService;
using BSWebtoon.Front.Service.CloudinaryService;

using BSWebtoon.Front.Service.ActivityService;
using BSWebtoon.Front.Service.UploadService;
using BSWebtoon.Front.Service.AccountService;
using BSWebtoon.Front.Service.RecordViewService;
using BSWebtoon.Model.Repository.Interface;
using Coravel;
using BSWebtoon.Front.Service.JobService;

namespace BSWebtoon.Front
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
            services.AddHttpClient();

            services.AddControllersWithViews();


            //註冊
            services.AddScoped<ICloudinaryService, CloudinaryService>();

            services.AddScoped<IUploadService, UploadService>();


            services.AddScoped<BSRepository, BSRepository>();
            services.AddScoped<IActivityService, ActivityService>();
            services.AddScoped<IRecommendService, RecommendService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IRechargeService, RechargeService>();
            services.AddScoped<ICouponService, CouponService>();
            services.AddScoped<IClickRecordService, ClickRecordService>();
            services.AddScoped<IFavoriteService, FavoriteService>();
            services.AddScoped<ClickRecordService, ClickRecordService>();
            //services.AddDbContext<BSWeBtoonContext, BSWeBtoonContext>();
            services.AddScoped<IComicService, ComicService>();
            services.AddScoped<IRecordViewService, RecordViewService>();
            services.AddScoped<ISearchService, SearchService>();
            services.AddScoped<IWeekUpdateService, WeekUpdateService>();
            services.AddScoped<IMemberService, MemberService>();
            services.AddScoped<IAccountService, AccountService>();

            //註冊redis資料庫
            services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = Configuration["RedisConfig:ToolManMemoryCache"];
            });

            services.AddTransient<IMemoryCacheRepository, MemoryCacheRepository>();

            services.AddHttpContextAccessor();

            // 藍新 維持 Json 回傳大小寫與 ViewModel 相同
            services.AddMvc().AddJsonOptions(options => { options.JsonSerializerOptions.PropertyNamingPolicy = null; });
            services.AddControllers().AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

            services.AddDbContext<BSWebtoonDbContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("BSWebtoonDbContext")));
            //第三方登入(yu)
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    //全部寫得和預設值一樣`

                    //設定登入Action的路徑： 
                    //options.LoginPath = new PathString("/Account/Login");

                    ////設定 導回網址 的QueryString參數名稱：
                    //options.ReturnUrlParameter = "ReturnUrl";

                    ////設定登出Action的路徑： 
                    //options.LogoutPath = new PathString("/Account/Logout");

                    ////若權限不足，會導向的Action的路徑
                    //options.AccessDeniedPath = new PathString("/Account/AccessDenied");
                })
                .AddFacebook(options =>
                {
                    var provider = "FB";
                    options.AppId = Configuration[$"Authentication:{provider}:ClientId"];
                    options.AppSecret = Configuration[$"Authentication:{provider}:ClientSecret"];
                })
                .AddGoogle(options =>
                 {
                     var provider = "Google";
                     options.ClientId = Configuration[$"Authentication:{provider}:ClientId"];
                     options.ClientSecret = Configuration[$"Authentication:{provider}:ClientSecret"];

                 })
                .AddLine(options =>
                {
                    var provider = "Line";
                    options.ClientId = Configuration[$"Authentication:{provider}:ClientId"];
                    options.ClientSecret = Configuration[$"Authentication:{provider}:ClientSecret"];
                    options.Scope.Add("email");

                });

            services.AddTransient<DailyJob>();
            services.AddTransient<WeeklyJob>();

            services.AddScheduler();
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
                scheduler.Schedule<DailyJob>().DailyAtHour(0).RunOnceAtStart();
                scheduler.Schedule<WeeklyJob>().Weekly().Sunday().RunOnceAtStart();
            });

            app.UseRouting();

            app.UseAuthentication(); //要有這行，順序一定要在UseAuthorization()之前
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Recommend}/{action=Recommend}/{id?}");

                //顯示排行榜
                endpoints.MapControllerRoute(
                    name: "Rank",
                    pattern: "Ranking",
                    defaults: new { controller = "Rank", action = "AllRankList" }
                    );

                //顯示搜尋
                endpoints.MapControllerRoute(
                    name: "SearchComic",
                    pattern: "Search",
                    defaults: new { controller = "Search", action = "SearchComic" });

                //顯示歷史觀看紀錄
                endpoints.MapControllerRoute(
                    name: "RecordView",
                    pattern: "Record",
                    defaults: new { controller = "Favorite", action = "RecordView" });
                
                //顯示我的最愛
                endpoints.MapControllerRoute(
                    name: "Favorite",
                    pattern: "Favorite",
                    defaults: new { controller = "Favorite", action = "ReadFavoriteView" });

                //顯示儲值金幣
                endpoints.MapControllerRoute(
                    name: "CashPlanView",
                    pattern: "Recharge",
                    defaults: new { controller = "Recharge", action = "CashPlanView" });

                //顯示上傳作品
                endpoints.MapControllerRoute(
                    name: "UploadComic",
                    pattern: "UploadComic",
                    defaults: new { controller = "UpLoad", action = "UploadComic" });

                //顯示上傳作品畫次
                endpoints.MapControllerRoute(
                    name: "UploadWork",
                    pattern: "UploadWork",
                    defaults: new { controller = "Upload", action = "UploadWork" });


                //顯示漫畫
                endpoints.MapControllerRoute(
                    name: "UploadWork",
                    pattern: "WorksPage/{Id}",
                    defaults: new { controller = "WorksPage", action = "WorksPage" });

                //顯示漫畫新作
                endpoints.MapControllerRoute(
                    name: "NewComic",
                    pattern: "NewComic",
                    defaults: new { controller = "WeekUpdate", action = "NewComic" });
                
                //顯示星期列表漫畫
                endpoints.MapControllerRoute(
                    name: "WeekUpdate",
                    pattern: "WeekUpdate",
                    defaults: new { controller = "WeekUpdate", action = "WeekUpdate" });

                //顯示完結漫畫
                endpoints.MapControllerRoute(
                    name: "FinishComic",
                    pattern: "FinishComic",
                    defaults: new { controller = "WeekUpdate", action = "FinishComic" });

                //顯示活動內容頁
                endpoints.MapControllerRoute(
                    name: "ActivityContent",
                    pattern: "ActivityContent/{Id}",
                    defaults: new { controller = "Activity", action = "ActivityContent" });

                //顯示活動
                endpoints.MapControllerRoute(
                    name: "GiftBox",
                    pattern: "GiftBox",
                    defaults: new { controller = "Activity", action = "GiftBox" });

            });

        }

    }
}
