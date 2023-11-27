using ECommersAdminPanel2.Options;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages(options =>
{
    options.Conventions.AuthorizePage("/Index");
    options.Conventions.AuthorizePage("/LogOut");
    options.Conventions.AuthorizePage("/MerchVisit");
    options.Conventions.AuthorizePage("/OrderPage");
});

builder.Services.AddCors();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
{
    options.LoginPath = "/Login";
}
);

builder.Services.AddAuthorization();
builder.Services.AddMvc().AddJsonOptions(options => { options.JsonSerializerOptions.PropertyNamingPolicy = new EComersJsonOptions(); });


var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseCors(p => p.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
