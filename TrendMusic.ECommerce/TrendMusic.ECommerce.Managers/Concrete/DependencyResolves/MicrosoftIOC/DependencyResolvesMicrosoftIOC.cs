using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;
using TrendMusic.ECommerce.Core.IdentityLibrary;
using TrendMusic.ECommerce.Core.Utilities.Options;
using TrendMusic.ECommerce.DataAccess.EntityFramework.Abstract;
using TrendMusic.ECommerce.DataAccess.EntityFramework.Concrete.Contexts;
using TrendMusic.ECommerce.DataAccess.EntityFramework.Concrete.UnitOfWork;
using TrendMusic.ECommerce.Entities.Concrete.Identity;
using TrendMusic.ECommerce.Managers.Abstract;
using TrendMusic.ECommerce.Managers.Abstract.Managers;
using TrendMusic.ECommerce.Managers.Concrete.Managers;

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

            AddAuthenticaton(Services, enviroment);
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
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }

        /// <summary>
        /// DbContext ayarlandı.
        /// </summary>
        private static void AddDbContext(IServiceCollection services, IConfiguration configuration, IHostEnvironment enviroment)
        {

            services.AddDbContext<MyDbContext>(x =>
            {
                var ConnectionString = configuration.GetSection("ApplicationSettings:ConnectionStrings").Value.ToString();
                x.UseSqlServer(ConnectionString);

                if (enviroment.IsDevelopment()) // Development modu için Entity Framework Logları incelenmek İstenebilir. 
                {
                    x.EnableSensitiveDataLogging(true); // veritabanı loglaması için aktif hale getirildi. 
                }
                 
            });
            using (var serviceProvider = services.BuildServiceProvider())
            {
                var dbContext = serviceProvider.GetRequiredService<MyDbContext>();
                dbContext.Database.Migrate();
            }
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
            services.AddSingleton<ICookieService, CookieManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ILoginService, LoginManager>();
        }
        /// <summary>
        ///  Automapper ekler 
        /// </summary>
        private static void AddMapper(IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }

        /// <summary>
        /// Authentication ayarları buradan yapılmaktadır 
        /// </summary>
        /// <param name="services"></param>
        /// <param name="enviroment"></param>
        private static void AddAuthenticaton(IServiceCollection services, IHostEnvironment enviroment)
        {
            /// Login ve Logout işlemleri için development ta configurasyonların uzun uğraştırmasını engellemek maksatlı bu şekilde bir geliştirme yapıldı 
            if (enviroment.IsDevelopment())
            {
                services.AddIdentityCore<AppUser>(x =>
                {
                    x.SignIn.RequireConfirmedPhoneNumber = false;
                    x.SignIn.RequireConfirmedEmail = false;
                    x.SignIn.RequireConfirmedAccount = false;
                    x.Password.RequireDigit = false;
                    x.Password.RequiredLength = 1;
                    x.Password.RequiredUniqueChars = 0;
                    x.Password.RequireUppercase = false;
                    x.Password.RequireNonAlphanumeric = false;
                    x.Password.RequireLowercase = false;
                }).AddEntityFrameworkStores<MyDbContext>().AddErrorDescriber<CostumeIdentityErrorDescriber>();


            }
            else
            {
				services.AddIdentityCore<AppUser>(x =>
				{

				}).AddEntityFrameworkStores<MyDbContext>().AddErrorDescriber<CostumeIdentityErrorDescriber>();
			}


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

            #region Manual ( Old Method )
            //services.AddSingleton<IValidator<AddAppUserDto>, AddAppUserValidationRules>();
            #endregion

        }
        #endregion



    }
}
