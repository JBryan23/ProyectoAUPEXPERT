using AUPExpert.Application.UseCases;
using AUPExpert.Persistence;
using AUPExpert.Service.WebUI.Components;
using AUPExpert.Service.WebUI.Modules.Injection;
using AUPExpert.Service.WebUI.Modules.MudBlazor;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
//componentes de mud blazor
builder.Services.AddMudBlazor();

builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddApplicationServices(builder.Configuration);

//agregar servicios de applicacion y infraestructura
builder.Services.AddInjection(builder.Configuration);

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
