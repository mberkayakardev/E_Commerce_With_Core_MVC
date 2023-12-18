using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;
using TrendMusic.ECommerce.Core.Utilities.Options;
using TrendMusic.ECommerce.DataAccess.EntityFramework.Abstract;
using TrendMusic.ECommerce.DataAccess.EntityFramework.Concrete.Contexts;
using TrendMusic.ECommerce.DataAccess.EntityFramework.Concrete.UnitOfWork;

namespace TrendMusic.ECommerce.Managers.Concrete.DependencyResolves.MicrosoftIOC
{
    public static class DependencyResolvesMicrosoftIOC
    {
        public static void AddCostumeDependencies(this IServiceCollection Services, IConfiguration Configuration, IHostEnvironment enviroment)
        {
            AddConfigurationFiles(Services, Configuration);

            AddAnotherConfigurationServices(Services, Configuration);

            AddDbContext(Services, Configuration, enviroment);

            AddUnitOfWork(Services, Configuration);

            AddDependencies(Services);

            AddValidationRules(Services);

            AddMapper(Services);

            AddAuthenticaton(Services);
        }
        #region Methods
        /// <summary>
        /// Option pattern ile birlikte multiple appsettings.json u ekler enviroment ortalına göre ilgili appsettings register olur
        /// </summary>
        private static void AddConfigurationFiles(IServiceCollection services, IConfiguration configuration)
        {
            /// Otomatik algılayabildiğini öğrendim.

            //var environment = configuration.GetValue<string>("ASPNETCORE_ENVIRONMENT");
            //var appSettingsFileName = $"appsettings.{environment}.json";
            //var appSettingsPath = Path.Combine(Directory.GetCurrentDirectory(), appSettingsFileName);
            //var appSettings = new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile(appSettingsPath, optional: true)
            //    .Build();
            //services.Configure<AppSettings>(configuration.GetSection("AppSettings"));

            services.Configure<AppSettingsOptions>(x =>
            {
                x.ConnectionString = configuration.GetSection("AppSettings:ConnectionString").Value.ToString();
                x.MainterenceMode = Convert.ToBoolean(configuration.GetSection("AppSettings:MainterenceMode").Value);
            });

        }

        /// <summary>
        /// Cookie, Session, gibi yapılandırmalar eklenir.
        /// </summary>
        private static void AddAnotherConfigurationServices(IServiceCollection services, IConfiguration configuration)
        {
            //services.AddSession(); // Ekleyemedim
            services.AddMemoryCache();
            //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }

        /// <summary>
        /// DbContext ayarlandı.
        /// </summary>
        private static void AddDbContext(IServiceCollection services, IConfiguration configuration, IHostEnvironment enviroment)
        {
            services.AddDbContext<MyDbContext>(x =>
            {
                x.UseSqlServer(configuration.GetSection("ApplicationSettings:ConnectionStrings").GetSection("ConnectionStrings").Value.ToString());

                if (enviroment.IsDevelopment()) // Development modu için Entity Framework Logları incelenmek İstenebilir. 
                {
                    x.EnableSensitiveDataLogging(true); // veritabanı loglaması için aktif hale getirildi. 
                }
            });
        }

        private static void AddUnitOfWork(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        /// <summary>
        /// Proje bağlılıkları eklenir.
        /// </summary>
        private static void AddDependencies(IServiceCollection services)
        {
            #region Automatic Register For IValidator




            #endregion
            //services.AddScoped<IProviderServicesService, ProviderServicesManager>();
        }
        /// <summary>
        ///  Automapper ekler 
        /// </summary>
        private static void AddMapper(IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }

        private static void AddValidatons(IServiceCollection services)
        {
            #region Fluent Validation Otomatik Register
            var assemblyList = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.BaseType.Name.Contains("AbstractValidator")).ToList();
            foreach (var item in assemblyList)
            {
                var DtoType = item.BaseType.GetGenericArguments()[0];
                services.AddSingleton(typeof(IValidator<>).MakeGenericType(DtoType), item);
            }
            #endregion

            #region Manual
            //services.AddSingleton<IValidator<AddAppUserDto>, AddAppUserValidationRules>();
            //services.AddSingleton<IValidator<UpdateAppUserDto>, UpdateAppUserValidatonRules>();
            //services.AddSingleton<IValidator<DeleteAppUserDto>, DeleteAppUserDtoValidationRules>();
            #endregion

        }

        private static void AddAuthenticaton(IServiceCollection services)
        {
            //services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            //    .AddCookie(opt =>
            //    {
            //        opt.LogoutPath = new PathString("/singout");
            //        opt.LoginPath = new PathString("/singin");
            //        opt.AccessDeniedPath = new PathString("/forbidden");

            //        opt.Cookie.Name = "AkarSoftWare";
            //        opt.Cookie.HttpOnly = true;
            //        opt.Cookie.SameSite = SameSiteMode.Strict;
            //        opt.ExpireTimeSpan = TimeSpan.FromDays(60);
            //    });
        }


        private static void AddValidationRules(IServiceCollection services)
        {
            #region Fluent Validation Otomatik Register
            var assemblyList = Assembly.GetExecutingAssembly().GetTypes().Where(x => x.BaseType != null).Where(x => x.BaseType.Name.Contains("AbstractValidator")).ToList();
            foreach (var item in assemblyList)
            {
                var DtoType = item.BaseType.GetGenericArguments()[0];
                services.AddSingleton(typeof(IValidator<>).MakeGenericType(DtoType), item);
            }
            #endregion

            #region Manual
            //services.AddSingleton<IValidator<AddAppUserDto>, AddAppUserValidationRules>();
            #endregion

        }
        #endregion



    }
}
