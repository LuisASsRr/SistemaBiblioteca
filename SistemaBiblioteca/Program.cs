using Microsoft.AspNetCore.Components.Web;
    
    // Necesario para componentes Blazor
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using SistemaBiblioteca.Data;

var builder = WebApplication.CreateBuilder(args);

// ==========================================================
// 1. REGISTRO DE SERVICIOS (Dependency Injection Container)
// ==========================================================

// Servicios principales de MVC
builder.Services.AddControllersWithViews();

// Servicios necesarios para el Host Blazor Server y enrutamiento .razor
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor(); // Soporte completo para Blazor Server
builder.Services.AddSignalR();          // Necesario para la comunicación en tiempo real de Blazor (Soluciona el último error)

// Servicios de UI: MudBlazor (Corrige el error IBrowserViewportService)
builder.Services.AddMudServices();

// Servicios de la Base de Datos: Entity Framework Core (SQL Server)
builder.Services.AddDbContext<BibliotecaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// ==========================================================
// 2. CONSTRUCCIÓN DE LA APLICACIÓN (HTTP Pipeline)
// ==========================================================

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// ==========================================================
// 3. DEFINICIÓN DE ENDPOINTS
// ==========================================================

// Endpoint para la comunicación Blazor en tiempo real
app.MapBlazorHub();


// Enrutamiento estándar de MVC
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();