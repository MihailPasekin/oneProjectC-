using EComersDBworkerLib;
using EComersObjectLib.Objects;
using EComersObjectLib.SapObjects;
using EComersWebApiEmploe.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SapDBWorkerLib;

namespace EComersWebApiEmploe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarehouseController : ControllerBase
    {
        [Route("getsaploadingitems")]
        [HttpGet]
        public async Task<ActionResult<List<LoadingReport>>> GetListSapDeliveryLines([FromServices] InitSapDbWorker initSapDbWorker, DateTime docDate, string empID)
        {
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            if (sapDBWorker.Connected())
            {
                return await Task.Run(new Func<ActionResult<List<LoadingReport>>>(() => new ActionResult<List<LoadingReport>>(sapDBWorker.GetLoadingWarehouseReport(docDate, empID))));
            };

            return new OkObjectResult(new List<LoadingReport>()); ;
        }

        [Route("getsapforwarderdocs")]
        [HttpGet]
        public async Task<ActionResult<List<ForwarderDocList>>> GetForwarderDocReport([FromServices] InitSapDbWorker initSapDbWorker, DateTime docDate, string empID)
        {
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            if (sapDBWorker.Connected())
            {
                return await Task.Run(new Func<ActionResult<List<ForwarderDocList>>>(() => new ActionResult<List<ForwarderDocList>>(sapDBWorker.GetForwarderDocReport(docDate, empID))));
            };

            return new OkObjectResult(new List<ForwarderDocList>()); ;
        }

        [Route("getwarehousessap")]
        [HttpGet]
        public async Task<ActionResult<List<WarehousesSapGet>>> GetSapWarehouses([FromServices] InitSapDbWorker initSapDbWorker)
        {
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            if (sapDBWorker.Connected())
            {
                return await Task.Run(new Func<ActionResult<List<WarehousesSapGet>>>(() => new ActionResult<List<WarehousesSapGet>>(sapDBWorker.GetWarehousesSap())));
            };

            return new OkObjectResult(new List<WarehousesSapGet>()); ;
        }

        [Route("getproductgroupsap")]
        [HttpGet]
        public async Task<ActionResult<List<SqlProductGroup>>> GetProductGroupName([FromServices] InitSapDbWorker initSapDbWorker)
        {
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            if (sapDBWorker.Connected())
            {
                return await Task.Run(new Func<ActionResult<List<SqlProductGroup>>>(() => new ActionResult<List<SqlProductGroup>>(sapDBWorker.GetProductGroup())));
            };

            return new OkObjectResult(new List<SqlProductGroup>()); 
        }

        [Route("getwarehousewithdrawal")]
        [HttpGet]
        public async Task<ActionResult<List<WarehouseWithdrawal>>> GetWarehouseWithdrawal([FromServices] InitSapDbWorker initSapDbWorker,  string? stock, string? idProductGroup, string? response)
        {
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            
            if (sapDBWorker.Connected())
            {
                return await Task.Run(new Func<ActionResult<List<WarehouseWithdrawal>>>(() => new ActionResult<List<WarehouseWithdrawal>>(sapDBWorker.GetWarehouseWithdrawalSql( stock , idProductGroup, response))));
            };

            return new OkObjectResult(new List<WarehouseWithdrawal>()); 
        }

        [Route("getproductgroupsproperties")]
        [HttpGet]
        public async Task<ActionResult<List<ProductGroupsPropertiesSql>>> GetProductGroupsProperties([FromServices] InitSapDbWorker initSapDbWorker)
        {
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            if (sapDBWorker.Connected())
            {
                return await Task.Run(new Func<ActionResult<List<ProductGroupsPropertiesSql>>>(() => new ActionResult<List<ProductGroupsPropertiesSql>>(sapDBWorker.GetProductGroupsPropertiesSql())));
            };

            return new OkObjectResult(new List<ProductGroupsPropertiesSql>());
        }

        [Route("getdeliveryforreportsql")]
        [HttpGet]
        public async Task<ActionResult<List<DeliveryForReport>>> GetDeliveryForReport([FromServices] InitSapDbWorker initSapDbWorker)
        {
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            if (sapDBWorker.Connected())
            {
                return await Task.Run(new Func<ActionResult<List<DeliveryForReport>>>(() => new ActionResult<List<DeliveryForReport>>(sapDBWorker.GetDeliveryForReportSQL())));
            };

            return new OkObjectResult(new List<DeliveryForReport>());
        }

        [Route("getdeliveryreportbyregion")]
        [HttpGet]
        public async Task<ActionResult<List<DeliveryForReport>>> GetDeliveryForReportByRegion([FromServices] InitSapDbWorker initSapDbWorker, string region)
        {
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            if (sapDBWorker.Connected())
            {
                return await Task.Run(new Func<ActionResult<List<DeliveryForReport>>>(() => new ActionResult<List<DeliveryForReport>>(sapDBWorker.GetDeliveryForReportByRegion(region))));
            };

            return new OkObjectResult(new List<DeliveryForReport>());
        }

    }
}
