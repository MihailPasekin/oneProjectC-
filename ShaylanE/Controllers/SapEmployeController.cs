using EComersObjectLib.Objects;
using EComersObjectLib.SapObjects;
using EComersWebApiEmploe.Services;
using Microsoft.AspNetCore.Mvc;
using SapDBWorkerLib;

namespace EComersWebApiEmploe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SapEmployeController : ControllerBase
    {
        [Route("getsapemployes")]
        [HttpGet]
        public async Task<ActionResult<List<object>>> GetSapEmployesAsync([FromServices] InitSapDbWorker initSapDbWorker)
        {
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();
            
            try
            {
                if (sapDBWorker.Connected())
                {
                    return new OkObjectResult(sapDBWorker.GetListSapEmploye());
                }

                return new OkObjectResult("Connection false");
            }
            catch (Exception ex)
            {
                return new OkObjectResult(ex);
            }
        }

        [Route("getsapemployebycode")]
        [HttpGet]
        public async Task<ActionResult<object>> GetSapEmployeAsync([FromServices] InitSapDbWorker initSapDbWorker, int code)
        {
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            try
            {
                if (sapDBWorker.Connected())
                {
                    return await Task.Run(new Func<ActionResult<object>>(() => new ActionResult<object>(sapDBWorker.GetSapEmployeByCode(code))));
                };

                return new OkObjectResult("Connection false");
            }
            catch (Exception ex)
            {
                return new OkObjectResult(ex);
            }
        }

        [Route("getsapemployrootebycode")]
        [HttpGet]
        public async Task<ActionResult<List<EmployeRoot>>> GetSapEmployeRootAsync([FromServices] InitSapDbWorker initSapDbWorker, int code)
        {
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            try
            {
                if (sapDBWorker.Connected())
                {
                    return await Task.Run(new Func<ActionResult<List<EmployeRoot>>>(() => new ActionResult<List<EmployeRoot>>(sapDBWorker.GetSapEmployeRoot(code))));
                };

                return new OkObjectResult("Connection false");
            }
            catch (Exception ex)
            {
                return new OkObjectResult(ex);
            }
        }

        [Route("getsapemployesbyjobtitle")]
        [HttpGet]
        public async Task<ActionResult<List<OHEM>>> GetSapEmployesByJobTitleAsync([FromServices] InitSapDbWorker initSapDbWorker, string jobTitle)
        {
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            try
            {
                if (sapDBWorker.Connected())
                {
                    return await Task.Run(new Func<ActionResult<List<OHEM>>>(() => new ActionResult<List<OHEM>>(sapDBWorker.GetListSapEmploye(jobTitle))));
                }

                return new OkObjectResult("Connection false");
            }
            catch (Exception ex)
            {
                return new OkObjectResult(ex);
            }
        }

        [Route("getsapemployesbyjobtitleregion")]
        [HttpGet]
        public async Task<ActionResult<List<OHEM>>> GetSapEmployesByJobTitleAsync([FromServices] InitSapDbWorker initSapDbWorker, string jobTitle, string region)
        {
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            try
            {
                if (sapDBWorker.Connected())
                {
                    return await Task.Run(new Func<ActionResult<List<OHEM>>>(() => new ActionResult<List<OHEM>>(sapDBWorker.GetListSapEmploye(jobTitle,region))));
                }

                return new OkObjectResult("Connection false");
            }
            catch (Exception ex)
            {
                return new OkObjectResult(ex);
            }
        }
    }
}
