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


            //���U
            services.AddScoped<ICloudinaryService, CloudinaryService>();

            services.AddScoped<IUploadService, UploadService>();


            services.AddScoped<BSRepository, BSRepository>();
            services.AddScoped<IActivityService, ActivityService>();
            services.AddScoped<IRecommendService, RecommendService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IRechargeService, RechargeService>();
            services.AddScoped<ICouponService, CouponService>();
            services.AddScoped<IClickRecordService, ClickRecordService>();
            services.AddScoped<FavoriteService, FavoriteService>();
            services.AddScoped<ClickRecordService, ClickRecordService>();
            //services.AddDbContext<BSWeBtoonContext, BSWeBtoonContext>();
            services.AddScoped<IComicService, ComicService>();
            services.AddScoped<ISearchService, SearchService>();
            services.AddScoped<IWeekUpdateService, WeekUpdateService>();
            services.AddScoped<IMemberService, MemberService>();
            services.AddScoped<IFavoriteService, FavoriteService>(); 
            services.AddScoped<IAccountService, AccountService>();


            services.AddHttpContextAccessor();

            // �ŷs ���� Json �^�Ǥj�p�g�P ViewModel �ۦP
            services.AddMvc().AddJsonOptions(options => { options.JsonSerializerOptions.PropertyNamingPolicy = null; });
            services.AddControllers().AddJsonOptions(options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

            services.AddDbContext<BSWebtoonDbContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("BSWebtoonDbContext")));
            //�ĤT��n�J(yu)
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    //�����g�o�M�w�]�Ȥ@��`

                    //�]�w�n�JAction�����|�G 
                    //options.LoginPath = new PathString("/Account/Login");

                    ////�]�w �ɦ^���} ��QueryString�ѼƦW�١G
                    //options.ReturnUrlParameter = "ReturnUrl";

                    ////�]�w�n�XAction�����|�G 
                    //options.LogoutPath = new PathString("/Account/Logout");

                    ////�Y�v�������A�|�ɦV��Action�����|
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

            app.UseRouting();

            app.UseAuthentication(); //�n���o��A���Ǥ@�w�n�bUseAuthorization()���e
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Recommend}/{action=Recommend}/{id?}");


            //endpoints.MapControllerRoute(
            //    name: "ProductsPagination",
            //    pattern: "WorksPage/{ComicId?}",
            //    defaults: new { controller = "Favorite", action = "ReadFavorite" });

            });

        }

    }
}
