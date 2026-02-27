using Microsoft.EntityFrameworkCore;
using Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Data;
using Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Repositories;
using Cooperativa_Multiservicios_Los_Patitos_R_L_Grupo_7.Bussines;

var builder = WebApplication.CreateBuilder(args);

// MVC + Razor
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

// DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseMySql(
        builder.Configuration.GetConnectionString("MysqlConnection"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("MysqlConnection"))
    );
});

// Repositories
builder.Services.AddScoped<IReservaRepository, ReservaRepository>();
builder.Services.AddScoped<IServicioRepository, ServicioRepository>();

// Business Layer
builder.Services.AddScoped<ReservasBusiness>();
builder.Services.AddScoped<ServiciosBusiness>();

var app = builder.Build();

// Pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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