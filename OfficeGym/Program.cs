using Microsoft.Extensions.Configuration;
using OfficeGym.Data;
using Microsoft.EntityFrameworkCore;
using OfficeGym.Migrations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

string? connectionString = builder.Configuration.GetConnectionString("MvcOfficeGymDbContext");
connectionString = connectionString is null ? "" : connectionString;

builder.Services.AddDbContext<MvcOfficeGymDbContext>(options =>
  options.UseSqlServer(connectionString)
);

var app = builder.Build();

Seed.SeedData(app);

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
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
