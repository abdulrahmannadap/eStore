using eStore.Application.common.Interfaces;
using eStore.Domain.Entity;
using eStore.Infrastructure.Data;
using eStore.Infrastructure.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Stripe;

namespace eStore.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<ApplicationDbContext>(opt =>
            {
                var connectionString = builder.Configuration.GetValue<string>("MyConnectionStrings:DefaultConnection");
                opt.UseSqlServer(connectionString);
            });
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddIdentity<ApplicationUser, IdentityRole>(opt =>
            {

            }).AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();
            var app = builder.Build();
            //StripeConfiguration.ApiKey = builder.Configuration.GetSection("Stripe:SecretKey").Get<string>();
            StripeConfiguration.ApiKey = builder.Configuration.GetValue<string>("Stripe:SecretKey");
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
