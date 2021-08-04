using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Globalization;
using System.IO;
using System.Reflection;

using FrontEnd.TravelWithYou.Resources;
using Microsoft.AspNetCore.Mvc.Razor;
using FrontEnd.TravelWithYou.Core.Destinations;
using FrontEnd.TravelWithYou.Data.Destinations;
using Microsoft.Extensions.FileProviders;
using Microsoft.AspNetCore.ResponseCompression;
using System.IO.Compression;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.AspNetCore.Http;

namespace FrontEnd.TravelWithYou.Web
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


            //var redisCache = ConnectionMultipler.Connection(System.Environment.GetEnvironmentVariable("REDIS_CACHE"));
            //services.AddDataProtection()
            //    .SetApplicationName("FrontPage.ViajemosContigo")
            //    .SetDefaultKeyLifetime(TimeSpan.FromDays(30))
            //    .UseCryptographicalAlgorithms(
            //    new AuthenticaticatedEncryptorConfiguration() { 
                
            //    }).PersistKeysToStackExchangeRedis(redisCache);

            services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.AddMvc()
                .AddViewLocalization(LanguageViewLocationExpanderFormat.SubFolder, options => options.ResourcesPath = "Resources")
                .AddDataAnnotationsLocalization(options =>
                {
                    options.DataAnnotationLocalizerProvider = (_, factory) =>
                    {
                        var assemblyName = new AssemblyName(typeof(SharedResource).GetTypeInfo().Assembly.FullName);
                        return factory.Create("SharedResource", assemblyName.Name);
                    };
                });

            //HttpContextAccessor x;
            //x.HttpContext.Session.GetString("culture");
            var supportedCultures = new[] { new CultureInfo("es-MX"), new CultureInfo("en-US"), new CultureInfo("fr-CA") };
            services.Configure<RequestLocalizationOptions>(options =>
            {
                options.DefaultRequestCulture = new RequestCulture("es-MX");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
                //options.RequestCultureProviders.Insert(0, new QueryStringRequestCultureProvider());
                options.RequestCultureProviders = new List<IRequestCultureProvider>
                {
                    new QueryStringRequestCultureProvider(),
                    new CookieRequestCultureProvider()
                };
            });
            services.AddSingleton<IDestinationCore, DestinationCore>();
            services.AddSingleton<IDestinationData, DestinationData>();
            services.AddHttpClient();
            services.AddSession();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddResponseCompression(options=> 
            {
                options.Providers.Add<BrotliCompressionProvider>();
                options.Providers.Add<GzipCompressionProvider>();
                options.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(new[] { "image/svg+xml" });
            });
            services.Configure<GzipCompressionProviderOptions>(options=> 
                options.Level = CompressionLevel.Fastest
            );
            services.AddControllersWithViews().AddJsonOptions(options => 
                options.JsonSerializerOptions.PropertyNamingPolicy = null
            );
            services.Configure<IISServerOptions>(options=> 
                options.AllowSynchronousIO = true
            );
            services.Configure<KestrelServerOptions>(options =>
                options.AllowSynchronousIO = true
            );
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
            app.UseRequestLocalization();

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json",
                    optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseAuthorization();
            // using Microsoft.Extensions.FileProviders;
            // using System.IO;
            //app.UseStaticFiles(new StaticFileOptions
            //{
            //    FileProvider = new PhysicalFileProvider(
            //        Path.Combine(env.ContentRootPath, "json")),
            //    RequestPath = "/json"
            //});

            app.UseRouting();

            app.UseAuthorization();

            /*app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });*/

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}
