using AutoMapper;
using Car.Core.Interfaces;
using Car.Infrastructure;
using Car.Infrastructure.Repository;
using Car.Service.AutoMapperProfile;
using Car.Service.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<PMSDbContext>(options =>
    options.UseInMemoryDatabase("demo"));
//builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient(typeof(CarInventoryService), typeof(CarInventoryService));
var config = new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new AutoMapperProfile());
});
builder.Services.AddLogging(loggingBuilder =>
{
    loggingBuilder.ClearProviders();
    loggingBuilder.AddLog4Net("log4net.config");
});
var mapper = config.CreateMapper();
builder.Services.AddSingleton(mapper);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=CarInventory}/{action=Index}/{id?}");

app.Run();
