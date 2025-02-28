using Lession7NETCORE.Models;
using Microsoft.EntityFrameworkCore;

namespace Lession7NETCORE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
              
            var connectionString = builder.Configuration.GetConnectionString("BookStoreString");
            builder.Services.AddDbContext<Tes1Context>(options =>
                options.UseSqlServer(connectionString));
            //c?u hình session
            builder.Services.AddDistributedMemoryCache();
            //
            builder.Services.AddHttpContextAccessor();
            builder.Services.AddSession(opt =>
            {
                opt.IdleTimeout = TimeSpan.FromMinutes(5);
                opt.Cookie.HttpOnly = true;
                opt.Cookie.IsEssential = true;
                opt.Cookie.Name = ".Devmaster.Session";
            });
            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            //
            app.UseSession();
            app.MapControllerRoute(
               name: "areas",
               pattern: " {area:exists}/{controller=Dashboard}/{action=Index}/{id?}");
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
