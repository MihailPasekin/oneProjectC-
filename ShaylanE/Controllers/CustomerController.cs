using EComersWebApiEmploe.Services;
using Microsoft.AspNetCore.Mvc;
using SapDBWorkerLib;
using EComersObjectLib.SapObjects;

namespace EComersWebApiEmploe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        
        [HttpGet]
        [Route("getsapcustomers")]
        
        public async Task<ActionResult<List<OCRD>>> GetSapCustomersAsync([FromServices] InitSapDbWorker initSapDbWorker)
        {
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            if (sapDBWorker.Connected())
            {
                return await Task.Run(new Func<ActionResult<List<OCRD>>>(() => new ActionResult<List<OCRD>>(sapDBWorker.GetListCustomers())));
            };

            return new List<OCRD>();
        }

        [HttpGet]
        [Route("getsapcustomersbycardname")]
        
        public async Task<ActionResult<List<OCRD>>> GetSapCustomersByCardNameAsync([FromServices] InitSapDbWorker initSapDbWorker, string cardName)
        {
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            if (sapDBWorker.Connected())
            {
                return await Task.Run(new Func<ActionResult<List<OCRD>>>(() => new ActionResult<List<OCRD>>(sapDBWorker.GetListCustomersByCardName(cardName))));
            };

            return new List<OCRD>();
        }

        [HttpGet]
        [Route("getupdatedsapcustomers")]
        
        public async Task<ActionResult<List<OCRD>>> GetUpdatedSapCustomersAsync([FromServices] InitSapDbWorker initSapDbWorker, string updateDate)
        {
            if (initSapDbWorker.GetSapDBWorker().Connected())
            {
                //return await Task.Run(new Func<ActionResult<List<OCRD>>>(() => new ActionResult<List<OCRD>>(sapDBWorker.GetUpdatedListCustomers(updateDate))));
                return await Task.Run(new Func<ActionResult<List<OCRD>>>(() => new ActionResult<List<OCRD>>(initSapDbWorker.GetCustomerList())));
            };

            return new List<OCRD>();
        }

        [HttpGet]
        [Route("getsapcustomersbyemp")]
        public async Task<ActionResult<List<OCRD>>> GetSapCustomersByEmpCodeAsync([FromServices] InitSapDbWorker initSapDbWorker, string empId)
        {
            if (initSapDbWorker.GetSapDBWorker().Connected())
            {
                return await Task.Run(new Func<ActionResult<List<OCRD>>>(() => new ActionResult<List<OCRD>>(initSapDbWorker.GetCustomerListByEmploye(int.Parse(empId)))));
            };

            return new List<OCRD>();
        }

    }
}
