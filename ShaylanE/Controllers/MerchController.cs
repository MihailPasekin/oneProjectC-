using EComersDBworkerLib;
using EComersObjectLib;
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
    public class MerchController : ControllerBase
    {
        private EComersContext eComersContext;

        public MerchController(EComersContext _eComersContext)
        {
            eComersContext = _eComersContext;
        }

        [HttpGet]
        [Route("getallmerchvisit")]
        public async Task<ActionResult<List<MerchVisit>>> GetAllMerchVisitApiAsync()
        {
            EComersDBWorker dBWorker = new EComersDBWorker(eComersContext);
            List<MerchVisit> merchVisit = await dBWorker.GetAllMerchVisitAsync();

            return new OkObjectResult(merchVisit);
        }

        [HttpGet]
        [Route("getmerchproductsoldstat")]
        public async Task<ActionResult<List<MerchProductSoldStat>>> GetMerchProductSoldStatAsync(int visitId)
        {
            EComersDBWorker dBWorker = new EComersDBWorker(eComersContext);
            List<MerchProductSoldStat> merchVisit = await dBWorker.GetMerchProductSoldStatByVisitIdAsync(visitId);

            return new OkObjectResult(merchVisit);
        }

        [HttpGet]
        [Route("getmerchvisitbyempid")]
        public async Task<ActionResult<List<MerchVisit>>> GetMerchVisitByEmpIdApiAsync(int empId)
        {
            EComersDBWorker dBWorker = new EComersDBWorker(eComersContext);
            List<MerchVisit> merchVisit = await dBWorker.GetMerchVisitByEmpIdAsync(empId);

            return new OkObjectResult(merchVisit);
        }

        [HttpPost]
        [Route("postmerchvisit")]
        public async Task<string> CreateMerchVisitAsync(MerchVisit merchVisit)
        {
            try
            {
                merchVisit.VisitDateTime = merchVisit.VisitDateTime.ToUniversalTime();
                EComersDBWorker dBWorker = new EComersDBWorker(eComersContext);
                await dBWorker.CreateMerchVisit(merchVisit);

                return "created";
            }
            catch 
            {
                // TO DO SAVE LOG MESSAGE
                return "error";
            }
        }

        [HttpGet]
        [Route("getmerchproduct")]
        public async Task<ActionResult<List<MerchProduct>>> GetAllMerchProductAsync()
        {
            EComersDBWorker dBWorker = new EComersDBWorker(eComersContext);
            List<MerchProduct> merchProduct = await dBWorker.GetMerchProductAllAsync();

            return new OkObjectResult(merchProduct);
        }

        [HttpGet]
        [Route("getmerchproductbygroupid")]
        public async Task<ActionResult<List<MerchProduct>>> GetMerchProductAsync(int groupId)
        {
            EComersDBWorker dBWorker = new EComersDBWorker(eComersContext);
            List<MerchProduct> merchProduct = await dBWorker.GetMerchProductAsync(groupId);

            return new OkObjectResult(merchProduct);
        }

        [HttpGet]
        [Route("getmerchproductgroup")]
        public async Task<ActionResult<List<MerchProductGroup>>> GetMerchProductGroupAsync()
        {
            EComersDBWorker dBWorker = new EComersDBWorker(eComersContext);
            List<MerchProductGroup> merchProductGroup = await dBWorker.GetMerchProductGroupAsync();
            

            return new OkObjectResult(merchProductGroup);
            
        }

        [HttpGet]
        [Route("getmerchgroup")]
        public async Task<ActionResult<List<MerchGroup>>> GetSapMerchGroupAsync([FromServices] InitSapDbWorker initSapDbWorker)
        {
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            if (sapDBWorker.Connected())
            {
                return await Task.Run(new Func<ActionResult<List<MerchGroup>>>(() => new ActionResult<List<MerchGroup>>(sapDBWorker.GetMerchListGroup())));
            };

            return new List<MerchGroup>();
        }

        [HttpPost]
        [Route("putcostommerch")]
        public async Task<string> PutSapCustomMerchAsync([FromServices] InitSapDbWorker initSapDbWorker, CustomMerch customMerch)
        {
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();
            
            if (sapDBWorker.Connected())
            {
                await Task.Run(new Func<string>(() => {
                    int visitId = sapDBWorker.CreateMerchVisit(customMerch);
                    if (customMerch.GroupScoreList != null)
                    {
                        if (customMerch.GroupScoreList.Count > 0)
                        {
                            foreach(GroupScore groupScore in customMerch.GroupScoreList)
                            {
                                groupScore.VisitId = visitId;
                                sapDBWorker.CreateGroupScore(groupScore);
                            }
                        }
                    }
                    if (customMerch.SkuScoreList != null)
                    {
                        if (customMerch.SkuScoreList.Count > 0)
                        {
                            foreach (SkuScore skuScore in  customMerch.SkuScoreList) 
                            {
                                skuScore.VisitId = visitId;
                                sapDBWorker.CreateSkuScore(skuScore);
                            }
                        }
                    }

                    return "created"; 
                }));

            };
            
            return "error";
        }
    }
}
