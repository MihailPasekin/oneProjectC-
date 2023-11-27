using EComersWebApiEmploe.Services;
using Microsoft.AspNetCore.Mvc;
using SapDBWorkerLib;
using EComersObjectLib.SapObjects;

namespace EComersWebApiEmploe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SapOrderController : Controller
    {
        [Route("getsaporderbydocentry")]
        [HttpGet]
        // GET: SapOrderController/Edit/5
        public async Task<ActionResult<object>> GetSapOrderByDocEntry([FromServices] InitSapDbWorker initSapDbWorker, int docEntry)
        {
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            if (sapDBWorker.Connected())
            {
                return await Task.Run(new Func<ActionResult<object>>(() => new ActionResult<object>(sapDBWorker.GetSapOrderByDocEntry(docEntry))));
            };

            return View();
        }
        [Route("getallopensaporder")]
        [HttpGet]
        // GET: SapOrderController/Edit/5
        public async Task<ActionResult<List<object>>> GetAllOpenSapOrder([FromServices] InitSapDbWorker initSapDbWorker)
        {
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            if (sapDBWorker.Connected())
            {
                return await Task.Run(new Func<ActionResult<List<object>>>(() => new ActionResult<List<object>>(sapDBWorker.GetListAllSapOrders())));
            };

            return View();
        }
        [Route("getallopensaporderbyregion")]
        [HttpGet]
        // GET: SapOrderController/Edit/5
        public async Task<ActionResult<List<object>>> GetAllOpenSapOrderByRegion([FromServices] InitSapDbWorker initSapDbWorker,string region)
        {
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            if (sapDBWorker.Connected())
            {
                return await Task.Run(new Func<ActionResult<List<object>>>(() => new ActionResult<List<object>>(sapDBWorker.GetListAllSapOrdersByRegion(region))));
            };

            return View();
        }
        [Route("getsaporder")]
        [HttpGet]
        // GET: SapOrderController/Edit/5
        public async Task<ActionResult<List<object>>> GetSapOrderByOwnerCode([FromServices] InitSapDbWorker initSapDbWorker,string code)
        {
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            if (sapDBWorker.Connected()) 
            {
                return await Task.Run(new Func<ActionResult<List<object>>>(() => new ActionResult<List<object>>(sapDBWorker.GetListSapOrders(code))));
            };

            return View();
        }
        [Route("getsaporderlines")]
        [HttpGet]
        // GET: SapOrderController/Edit/5
        public async Task<ActionResult<List<RDR1>>> GetListSapOrdersLines([FromServices] InitSapDbWorker initSapDbWorker, int docEntry)
        {
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            if (sapDBWorker.Connected())
            {
                return await Task.Run(new Func<ActionResult<List<RDR1>>>(() => new ActionResult<List<RDR1>>(sapDBWorker.GetListSapOrdersLines(docEntry))));
            };

            return View();
        }

    }
}
