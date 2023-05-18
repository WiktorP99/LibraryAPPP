using LibraryAPPP.DB.DTO;
using LibraryAPPP.Repository.LibraryRepository;
using LibraryAPPP.Repository.RentRepository;
using LibraryAPPP.Repository.SalesOrderRepository;
using LibraryAPPP.Repository.UserRepository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LibraryAPPP
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
            services.AddDbContext<LibraryDBContext>(x => x.UseSqlServer(Configuration["ConnectionStrings:LibraryDB"]));

            services.AddMvc();
            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddSingleton<IConfiguration>(Configuration);
            services.AddScoped<ILibraryRepository, LibraryRepository>();
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<ISalesOrderRepository, SalesOrderRepository>();
            services.AddScoped<IRentRepository, RentRepository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
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
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
