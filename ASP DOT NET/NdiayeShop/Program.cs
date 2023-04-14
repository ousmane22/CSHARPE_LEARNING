using BethanysPieShop.Models;
using Microsoft.EntityFrameworkCore;
using NdiayeShop.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ICategoryRepository,CategoryRepository>();
builder.Services.AddScoped<IPieRepository,PieRepository>();

builder.Services.AddDbContext<NdiayeShopDbContext>(options => {
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:NdiayeShopConnection"]);
});

var app = builder.Build();

app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapDefaultControllerRoute();
DbInitializer.Seed(app);
app.Run();
