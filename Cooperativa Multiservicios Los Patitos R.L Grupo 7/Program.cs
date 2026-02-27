using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Cooperativa_Multiservicios_Los_Patitos_R.L_Grupo_7.Data;

var builder = WebApplication.CreateBuilder(args);
//falta lo de  

// Add services to the container.
builder.Services.AddControllersWithViews();
// Repositories
builder.Services.AddScoped<Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Repositories.IReservaRepository,
    Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Repositories.ReservaRepository>();

builder.Services.AddScoped<Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Repositories.IServicioRepository,
    Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Repositories.ServicioRepository>();

// Services
builder.Services.AddScoped<Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Bussines.IReservaService,
    Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Bussines.ReservaService>();

builder.Services.AddScoped<Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Bussines.IServicioService,
    Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Bussines.ServicioService>();
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();


builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseMySql(
        builder.Configuration.GetConnectionString("MysqlConnection"),
        ServerVersion.AutoDetect(
            builder.Configuration.GetConnectionString("MysqlConnection")
        )
    );
});



//Repositorio
//CapaBussine


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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();