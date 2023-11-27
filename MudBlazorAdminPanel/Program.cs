using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.FileProviders;
using MudBlazor.Services;
using MudBlazorAdminPanel.Data;
using MudBlazorAdminPanel.Interfaces;
using MudBlazorAdminPanel.Services;
using System;

var builder = WebApplication.CreateBuilder(args);

StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);

// Add services to the container.
builder.Services.AddCors();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddMudServices();
builder.Services.AddSingleton<INavigation, NavigatorService>();

//builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true);

builder.Services.AddHttpClient<IOinvService, OinvService>(client =>
{

    client.BaseAddress = new Uri("http://192.168.0.141:5093");

});

builder.Services.AddHttpClient<IAccounting, AccountingService>(client =>
{

    client.BaseAddress = new Uri("http://192.168.0.141:5093");

});

builder.Services.AddHttpClient<IAccountingDetail, AccountingDetailService>(client =>
{

    client.BaseAddress = new Uri("http://192.168.0.141:5093");

});

builder.Services.AddHttpClient<IAuthenticationCustom, AuthenticationService>(client =>
{

    client.BaseAddress = new Uri("http://192.168.0.141:5093");

});

builder.Services.AddHttpClient<IWarehouse, WarehouseService>(client =>
{
    client.BaseAddress = new Uri("http://192.168.0.141:5093");
});

builder.Services.AddScoped<ExcelService>();

builder.Services.AddScoped<UserStateProvider>();
builder.Services.AddScoped<AuthenticationStateProvider>(s => s.GetRequiredService<UserStateProvider>());
builder.Services.AddScoped<IAuthenticationCustom, AuthenticationService>();
builder.Services.AddHttpContextAccessor();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
{
   // options.LoginPath = "/login";
   // options.LoginPath = "/orderPage";
}
);
builder.Services.AddAuthorization();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseCors(p => p.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.UseStaticFiles();

app.UseStaticFiles(new StaticFileOptions()
{
    FileProvider = new PhysicalFileProvider("C:\\Users\\operator-2\\Source\\Repos\\muhamedkurban83\\shaylan-e\\ShaylanE\\UploadedFiles\\"),
    RequestPath = new PathString("/UploadedFiles")
});

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();