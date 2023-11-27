using EComersObjectLib.SapObjects;
using EComersWebApiEmploe.Services;
using Microsoft.AspNetCore.Mvc;
using SapDBWorkerLib;

namespace EComersWebApiEmploe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : Controller
    {
        [HttpGet]
        [Route("getitems")]
        public async Task<ActionResult<List<OITM>>> GetSapItemsAsync([FromServices] InitSapDbWorker initSapDbWorker, string empid)
        {
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            if (sapDBWorker.Connected())
            {
                return await Task.Run(new Func<ActionResult<List<OITM>>>(() => new ActionResult<List<OITM>>(sapDBWorker.GetListItems(empid))));
            };

            return new List<OITM>();
        }

        [HttpGet]
        [Route("getitemcount")]
        public async Task<ActionResult<int>> GetSapItemCountAsync([FromServices] InitSapDbWorker initSapDbWorker, string itemCode)
        {
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            if (sapDBWorker.Connected())
            {
                return await Task.Run(new Func<ActionResult<int>>(() => new ActionResult<int>(sapDBWorker.GetItemWhsCount(itemCode))));
            };

            return 0;
        }

        [HttpGet]
        [Route("getitemgroups")]
        public async Task<ActionResult<List<OITB>>> GetSapItemGroupsAsync([FromServices] InitSapDbWorker initSapDbWorker)
        {
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            if (sapDBWorker.Connected())
            {
                return await Task.Run(new Func<ActionResult<List<OITB>>>(() => new ActionResult<List<OITB>>(sapDBWorker.GetItemGroupsListSql())));
            };

            return new List<OITB>();
        }
    }
}
