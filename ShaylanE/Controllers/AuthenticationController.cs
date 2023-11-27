using EcomersCryptoLib;
using EComersDBworkerLib;
using EComersObjectLib;
using EComersWebApiEmploe.AditionalModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Net;
using System.Security.Claims;

namespace EComersWebApiEmploe.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenticationController : ControllerBase
    {
        [Route("login")]
        [HttpPost]
        public async Task<IActionResult> LoginUser(AuthenticationParams authParams)
        {
            try
            {
                if (authParams is null) return StatusCode(400);

                using (var dbContext = new EComersContext())
                {

                    User? dbuser = dbContext.User.Where(p => p.Login == authParams.Login).ToList().FirstOrDefault();


                    if (dbuser is null) 
                    {
                        return StatusCode(400, "not found my error"); 
                    }
                    else
                    {
                        if (EcomersCrypto.VerifyHashedPassword(dbuser.PasswordHash, authParams.Password)) 
                        {
                            var claims = new List<Claim> { new Claim(ClaimTypes.Name, string.Concat(dbuser.Name, " ", dbuser.SecondName) ?? ""), new Claim("Login", dbuser.Login ?? "") };

                            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, "Cookies");

                            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                            return StatusCode(200);
                        }
                        else
                        {
                            return StatusCode(400, "wrong password");
                        }
                    }

                   
                }
            }
            catch (Exception ex)
            {
                return StatusCode(400);
            }
        }

        [Route("loginadminpanel")]
        [HttpPost]
        public async Task<IActionResult> LoginUserFromAdminPanel(AuthenticationParams authParams)
        {
            try
            {
                if (authParams is null) return StatusCode(400);

                using (var dbContext = new EComersContext())
                {

                    User? dbuser = (await dbContext.User.Where(p => p.Login == authParams.Login).Include(p=>p.Role).ToListAsync()).FirstOrDefault();


                    if (dbuser is null)
                    {
                        return StatusCode(401, "user_not_found");
                    }
                    else
                    {
                        if (EcomersCryptoLib.EcomersCrypto.VerifyHashedPassword(dbuser.PasswordHash, authParams.Password))
                        {
                            return StatusCode(200, JsonConvert.SerializeObject(dbuser, new JsonSerializerSettings() {ReferenceLoopHandling = ReferenceLoopHandling.Ignore}));
                        }
                        else
                        {
                            return StatusCode(401, "wrong_password");
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.Message);
            }
        }

        [Route("logout")]
        [HttpPost]
        public async Task<IActionResult> LogoutUser()
        {
            try
            {
                await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(400);
            }
        }
    }
}
