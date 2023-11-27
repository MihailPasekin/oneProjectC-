using EComersDBworkerLib;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SapDBWorkerLib;

namespace EComersWebApiEmploe.Services
{
    //[Route("account")]
    // [ApiController]
    public class AccountsReceivableController //: Controller
    {/*
        // [Route("getaccount")]
        //  [HttpGet("{code}")]
        public async Task<ActionResult> GetAccountByCodeAsync([FromServices] InitSapDbWorker sapDbWorkerService, string code)
        {
            int accountCode = 0;


            SapDBWorker sapDBWorker = new SapDBWorker(sapDbWorkerService.GetSapConectionOption().GetCompany());

            if (sapDbWorkerService.GetSapConectionOption().Connect())
            {
                accountCode = await Task.Run(new Func<int>(() => { return sapDBWorker.GetOwnerCode(code); }));
            }

            return new OkObjectResult(accountCode);
        }
        */
    }
}
