using StructureOfCatalogs.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddControllersWithViews();

var app = builder.Build();
app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=CreationDigitalImages}/{action=Index}/{id?}");

ClassWriteInTables.GetStatusDuplicateInTable();

app.Run();