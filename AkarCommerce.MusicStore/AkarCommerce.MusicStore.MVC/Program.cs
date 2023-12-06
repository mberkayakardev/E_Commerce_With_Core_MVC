var builder = WebApplication.CreateBuilder(args);


#region Services
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation(); // MVC import ve AddRazorTimeCompilation eklendi
#endregion

var app = builder.Build();

#region Middlewares
if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();
else
{
    app.UseStatusCodePagesWithReExecute("/status", "{code?}");
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}


app.UseRouting();
app.UseEndpoints(endpoints =>
{

    endpoints.MapControllerRoute(name: "default", pattern: "{controller}/{action}/{id?}", defaults: new { controller = "Home", action = "Index" });

});

#endregion


app.Run();


