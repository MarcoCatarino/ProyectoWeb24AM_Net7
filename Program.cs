using Microsoft.EntityFrameworkCore;
using ProyectoWeb24AM_NET._7.Context;
using ProyectoWeb24AM_NET._7.Services.IServices;
using ProyectoWeb24AM_NET._7.Services.IServices.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Register services here
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
builder.Configuration.GetConnectionString("DefaultConnection")));

//Inyecci�n de dependencias
builder.Services.AddTransient<IArticuloServices, ArticuloServices>();

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
    pattern: "{controller=Articulo}/{action=Index}/{id?}");

app.Run();
