using EComersWebApiEmploe.AditionalModels;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;
using System.Net;
using EComersObjectLib;

namespace ECommersAdminPanel.Pages
{
    [IgnoreAntiforgeryToken]
    public class LoginModel : PageModel
    {
        public string ErrorMessage { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            string apiResponse;
            var form = Request.Form;
            if (!form.ContainsKey("login") || !form.ContainsKey("password"))
            {
                ErrorMessage = "login и/или пароль не установлены";
                return Page();
            }

            AuthenticationParams authenticationParams = new AuthenticationParams() 
            {
                Login = form["login"],
                Password = form["password"]
            };

            HttpContent body = new StringContent(JsonConvert.SerializeObject(authenticationParams), Encoding.UTF8, "application/json");
            
            using (var httpClient = new HttpClient())
            {
                using (HttpResponseMessage response = await httpClient.PostAsync(" http://192.168.0.70:5093/Authentication/loginadminpanel", body))
                {
                    if(response.StatusCode == HttpStatusCode.OK)
                    {
                        apiResponse = await response.Content.ReadAsStringAsync();
                        User? dbuser = JsonConvert.DeserializeObject<User>(apiResponse);

                        if (dbuser != null)
                        {
                            var claims = new List<Claim> { new Claim(ClaimTypes.Name, string.Concat(dbuser.Name, " ", dbuser.SecondName) ?? ""), new Claim("Login", dbuser.Login ?? "") };

                            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "Cookies");

                            var properties = new AuthenticationProperties();
                            

                            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), properties);

                            return RedirectToPage("./Index");
                        }
                    }
                    else 
                    {
                        apiResponse = await response.Content.ReadAsStringAsync();
                        ErrorMessage = apiResponse;
                        return Page();
                    }
                }
            }
            return Page();
        }
    }
}
