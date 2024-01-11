using BlazorApp42.Components;
using BlazorApp42.Components.Core;
using BlazorApp42.Components.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContext<MyAppContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyAppContext") ?? throw new InvalidOperationException("Connection string not found.")));

builder.Services.AddScoped<ArtikelService>();
builder.Services.AddScoped<ArtikelInventarService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
