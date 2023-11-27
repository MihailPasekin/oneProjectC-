using EComersWebApiEmploe.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EComersWebApiEmploe.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OptionsController : ControllerBase
    {

        [Route("startsynch")]
        [HttpGet]
        public async Task<ActionResult> StartSynchAsync([FromServices] InitSapDbWorker initSapDbWorker)
        {
            
            try
            {
                initSapDbWorker.StartSynh();
                return new OkResult();
            }
            catch (Exception ex)
            {
                return new OkObjectResult(ex);
            }
        }
    }
}
