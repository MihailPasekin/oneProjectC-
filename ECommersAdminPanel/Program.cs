using EComersDBworkerLib;
using ECommersAdminPanel.Options;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<EComersContext>();
builder.Services.AddCors();
// Add services to the container.
/*
builder.Services.Configure<CookiePolicyOptions>(option => 
{
    option.CheckConsentNeeded = context => false;
    option.MinimumSameSitePolicy = SameSiteMode.None;
    option.HttpOnly = HttpOnlyPolicy.Always;
    option.Secure = CookieSecurePolicy.None;
});
*/
builder.Services.AddRazorPages(options =>
{
    options.Conventions.AuthorizePage("/Index");
   // options.Conventions.AuthorizePage("/LogOut");
});

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
{
    options.LoginPath = "/Login";
   // options.Cookie.HttpOnly = false;
  //  options.Cookie.SecurePolicy = CookieSecurePolicy.None;
}
);
builder.Services.AddAuthorization();
builder.Services.AddMvc().AddJsonOptions(options => { options.JsonSerializerOptions.PropertyNamingPolicy = new EComersJsonOptions(); });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
//app.UseHttpsRedirection();
//app.UseCookiePolicy();
app.UseStaticFiles();
app.UseCors(p => p.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();