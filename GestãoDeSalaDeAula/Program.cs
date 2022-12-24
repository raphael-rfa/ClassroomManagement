using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GestãoDeSalaDeAula.Data;
using GestãoDeSalaDeAula.Models;
using Microsoft.AspNetCore.Localization;
using System.Globalization;

namespace GestãoDeSalaDeAula
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<GestãoDeSalaDeAulaContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'GestãoDeSalaDeAulaContext' not found.")));

            // Add services to the container.
            builder.Services.AddControllersWithViews();            

                var app = builder.Build();

            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                var context = services.GetRequiredService<GestãoDeSalaDeAulaContext>();
                SeedData.Initialize(context);
            }

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

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Alunoes}/{action=Details}/{id=11}");

            app.Run();
        }
    }
}