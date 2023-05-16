using AspNetCoreHero.ToastNotification;
using Microsoft.EntityFrameworkCore;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using WebBanDongHo.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.Cookies;

internal class Program
{
    private static void Main(string[] args)
    {   
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddRazorPages();
        //    builder.Services.AddIdentity<IdentityUser, IdentityRole>()
        //.AddEntityFrameworkStores<dbMarketsContext>();
        // Add services to the container.
        builder.Services.AddSession();
        builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
        builder.Services.AddNotyf(config => { config.DurationInSeconds = 10; config.IsDismissable = true; config.Position = NotyfPosition.BottomRight; });
        builder.Services.AddDbContext<dbMarketsContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString
                  ("DefaulConnection")));
        builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(p =>
                {
                    p.Cookie.Name = "UserLoginCookie";
                    p.ExpireTimeSpan = TimeSpan.FromDays(1);
                    //p.LoginPath = "/dang-nhap.html";
                    //p.LogoutPath = "/logout.html";
                    p.AccessDeniedPath = "/login.html";
                    p.LoginPath = "/login.html";
                });


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
        app.UseSession();
        app.UseAuthentication();
        app.UseAuthorization();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "areas",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

            app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
        });

        app.MapRazorPages();

        app.Run();
    }
}



