using Microsoft.EntityFrameworkCore;
using System;

namespace LigaCup {
    public class Program {
        
        private static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddRazorPages();


            builder.Services.AddDbContext<LigaCupDB>(options => {
                options.UseSqlite("Data Source=app.db");
            });

            using (var dbContext = new LigaCupDB()) {
                dbContext.Database.EnsureCreated();
            }

            var app = builder.Build();

            if (!app.Environment.IsDevelopment()) {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}