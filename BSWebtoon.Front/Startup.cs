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
using BSWebtoon.Front.Service.WeekUpdateService;

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
            services.AddControllersWithViews();
            services.AddScoped<BSRepository, BSRepository>();
            services.AddScoped<IRecommendService, RecommendService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IRechargeService, RechargeService>();
            services.AddScoped<ICouponService, CouponService>();
            services.AddScoped<IClickRecordService, ClickRecordService>();
            //services.AddDbContext<BSWeBtoonContext, BSWeBtoonContext>();
            services.AddScoped<IComicService, ComicService>();
            services.AddScoped<IMemberService, MemberService>();
            services.AddScoped<IFavoriteService, FavoriteService>();
            services.AddDbContext<BSWebtoonContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("BSWebtoonContext")));
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Recommend}/{action=Recommend}/{id?}");
            });
        }
    }
}
