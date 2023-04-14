using Microsoft.EntityFrameworkCore;
using NdiayeShop.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<ICategoryRepository,MockCategoryRepository>();
builder.Services.AddScoped<IPieRepository,MockPieRepository>();

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

app.Run();
