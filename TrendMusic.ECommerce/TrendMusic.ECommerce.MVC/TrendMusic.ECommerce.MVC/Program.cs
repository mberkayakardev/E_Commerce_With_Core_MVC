using TrendMusic.ECommerce.Managers.Concrete.DependencyResolves.MicrosoftIOC;

var builder = WebApplication.CreateBuilder(args);

#region Services
builder.Services.AddControllersWithViews();
builder.Services.AddCostumeDependencies(builder.Configuration, builder.Environment);
#endregion
var app = builder.Build();

#region Middlewares
app.UseRouting();
#endregion

app.Run();
