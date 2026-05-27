var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
builder.Services.AddControllersWithViews();
builder.Services.Configure<RouteOptions>(options =>
{
    options.LowercaseUrls = true;
    options.LowercaseQueryStrings = true;
});
var app = builder.Build();
app.UseStaticFiles();
app.MapDefaultControllerRoute();
app.Run();