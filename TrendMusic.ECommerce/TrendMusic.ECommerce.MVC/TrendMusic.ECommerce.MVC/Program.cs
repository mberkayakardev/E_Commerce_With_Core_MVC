using TrendMusic.ECommerce.Managers.Concrete.DependencyResolves.MicrosoftIOC;
using TrendMusic.ECommerce.Managers.Concrete.Middlewares;

var builder = WebApplication.CreateBuilder(args);

#region Services
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation(); // Runtime içinde viewdeki değişiklikleri yansıtmak için ilgili ekleme gerçekleştirildi. 
builder.Services.AddCostumeDependencies(builder.Configuration, builder.Environment);
#endregion

var app = builder.Build();

#region Middlewares

if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();

else
{
    app.UseExceptionHandler("/exception");
    app.UseStatusCodePagesWithReExecute("/errors", "code?={0}"); // Costume Exception Handler
    app.UseHsts(); // Http yönlendirmeyi zorunlu kılmak için eklenmiştir. 
}

/// Https Yönlendirme
app.UseHttpsRedirection(); // Http Yönlendirme için 

/// Static Files Middleware
app.UseStaticFiles();
//app.UseStaticFiles(new StaticFileOptions { RequestPath = "/node_modules", FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory() + "node_modules")) });

// Routing
app.UseRouting();

// CORS
app.UseCors(x => { x.AllowAnyOrigin(); }); // Ajax için gelen her talep burada cors ayarlaması neticesinde filtrelenecek

// Authentication
app.UseAuthentication();

// Authorization
app.UseAuthorization();

// Costume Middlewares 
app.AddCostumeMiddlewares();

// Endpoint (conversational)
app.UseEndpoints(e => 
{
    e.MapControllerRoute(name: "defaults", pattern: "{Area=Customer}/{Controller=Product}/{Action=Index}/{id?}");
});
#endregion

app.Run();
