using AdminPanelBlazor.Data;
using AdminPanelBlazor.Interfaces;
using AdminPanelBlazor.Services;
using EComersObjectLib;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddSingleton<INavigation, NavigatorService>();

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

builder.Services.AddHttpClient<IAdminOptions, AdminOptionsService>(client =>
{
    client.BaseAddress = new Uri("http://192.168.0.141:5093");
});

builder.Services.AddHttpClient<IAdminOptions, AdminOptionsService>(client =>
{
    client.BaseAddress = new Uri("http://192.168.0.141:5093");
});
builder.Services.AddHttpClient<IAdminOptions, AdminOptionsService>(client =>
{
    client.BaseAddress = new Uri("http://192.168.0.70:5093");
});

builder.Services.AddScoped<ExcelService>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
builder.Services.AddScoped<AuthenticationService>();
builder.Services.AddHttpContextAccessor();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
{
    options.LoginPath = "/login";
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
    //FileProvider = new PhysicalFileProvider("D:\\Projects\\EComers\\EComers\\ShaylanE\\UploadedFiles\\"),
    FileProvider = new PhysicalFileProvider("C:\\Users\\misha\\source\\repos\\shaylan\\ShaylanE\\UploadedFiles\\"),
    //FileProvider = new PhysicalFileProvider("C:\\Users\\operator-2\\Source\\Repos\\muhamedkurban83\\shaylan-e\\ShaylanE\\UploadedFiles\\"),

    RequestPath = new PathString("/UploadedFiles")
});

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

