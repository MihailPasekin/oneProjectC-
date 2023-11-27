using EComersDBworkerLib;
using EComersObjectLib;
using EComersObjectLib.SapObjects;
using EComersWebApiEmploe.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EComersWebApiEmploe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private EComersContext eComersContext;

        public UserController(EComersContext eComersContext)
        {
            this.eComersContext = eComersContext;
        }

        [HttpPost]
        [Route("createuser")]
        public async Task<string> CreateUserAsync([FromBody] User user)
        {
            string errorMessage;
            try
            {
                if(user == null)
                {
                    errorMessage = "user is null";
                }
                else
                {
                    EComersDBWorker dBWorker = new EComersDBWorker(eComersContext);
                    return await dBWorker.CreateUserAsync(user);
                }
                
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }


            return errorMessage;
        }

        [Route("getusers")]
        [HttpGet]
        public async Task<ActionResult<List<User>>> GetEmployesAsync()
        {
            List<User> users;
            try
            {
                EComersDBWorker dBWorker = new EComersDBWorker(eComersContext);
                users = await dBWorker.GetAllUsers();

                return new OkObjectResult(users);
            }
            catch (Exception ex)
            {
                return new OkObjectResult(ex);
            }
        }
    }
}
