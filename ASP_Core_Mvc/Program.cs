using Infrastructure.Contexts;
using Infrastructure.Repositories;
using Infrastructure.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddRouting(x => x.LowercaseUrls = true);
builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));
builder.Services.AddScoped<AdressRepository>();
builder.Services.AddScoped<UserRepository>();
builder.Services.AddScoped<AdressService>();
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<FeatureService>();
builder.Services.AddScoped<FeatureRepository>();
builder.Services.AddScoped<FeatureItemRepository>();




var app = builder.Build();
app.UseHsts();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
