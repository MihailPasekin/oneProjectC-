using EComersDBworkerLib;
using EComersObjectLib;
using EComersObjectLib.Objects;
using EComersObjectLib.SapObjects;
using EComersWebApiEmploe.Services;
using Microsoft.AspNetCore.Mvc;
using SAPbobsCOM;
using SapDBWorkerLib;
using System.IO;

namespace EComersWebApiEmploe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MerchPlanController : ControllerBase
    {
        private EComersContext eComersContext;

        public MerchPlanController(EComersContext _eComersContext)
        {
            eComersContext = _eComersContext;
        }

        [HttpGet]
        [Route("getallmerchplans")]

        public async Task<List<MerchPlan>> GetSapCustomersAsync()
        {
            List<MerchPlan> listMerchPlan = new List<MerchPlan>();
            try
            {
                EComersDBWorker dBWorker = new EComersDBWorker(eComersContext);
                listMerchPlan = await dBWorker.GetAllMerchPlansAsync();
               

                return listMerchPlan;
            }
            catch (Exception ex)
            {
                return new List<MerchPlan>();
            }   
        }


        [HttpGet]
        [Route("getallplanreport")]

        public async Task<List<PlanReport>> GetPlanReportAsync()
        {
            List<PlanReport> listPlanReport = new List<PlanReport>();
            try
            {
                EComersDBWorker dBWorker = new EComersDBWorker(eComersContext);
                listPlanReport = await dBWorker.GetPlanReportAsync();
                return listPlanReport;
            }
            catch (Exception ex)
            {
                return new List<PlanReport>();
            }
        }

        [HttpGet]
        [Route("getemploemerchplans")]
        public async Task<List<MerchPlan>> GetSapCustomersEmpIdAsync(int empId)
        {
            List<MerchPlan> listMerchPlan = new List<MerchPlan>();
            try
            {
                EComersDBWorker dBWorker = new EComersDBWorker(eComersContext);
                listMerchPlan = await dBWorker.GetEmpIdMerchPlansAsync(empId);

                return listMerchPlan;
            }
            catch (Exception ex)
            {
                return new List<MerchPlan>();
            }
        }

        [HttpPost]
        [Route("postmerchplan")]
        public async Task<string> CreateMerchPlanApiAsync(MerchPlan merchPlan)
        {
            try
            {
                merchPlan.CreatedAt = merchPlan.CreatedAt.ToUniversalTime();
                EComersDBWorker dBWorker = new EComersDBWorker(eComersContext);
                await dBWorker.CreateMerchPlanAsync(merchPlan);

                return "created";
            }
            catch
            {
                // TO DO SAVE LOG MESSAGE
                return "error";
            }
        }

        [HttpPost]
        [Route("postmerchplanphoto")]
        public async Task<string> CreateMerchPlanPhotoApiAsync(IFormFile file)
        {
            try
            {
                string path = "";
                    
                if (file.Length > 0)
                {
                    path = Path.GetFullPath(Path.Combine("C:\\Users\\Aleksandr\\Desktop\\ReportPhoto\\"));
                    //path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "UploadedFiles"));
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    using (var fileStream = new FileStream(Path.Combine(path, file.FileName), FileMode.Create))
                    {
                        await file.CopyToAsync(fileStream);
                    }
                    return "create";
                }
                else
                {
                    return "error";
                }
                  
            }
            catch (Exception ex)
            {
                // TO DO SAVE LOG MESSAGE
                return $"error: {ex.Message}";
            }
        }

        [HttpPost]
        [Route("postcreateplanreport")]
        public async Task<string> CreatePlanRepor(PlanReport planReport)
        {
            try
            {
                string path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "UploadedFiles"));
                foreach (Photo photo in planReport.Photos)
                {
                    photo.FullFileName = Path.Combine(path, photo.FullFileName.Split('/').Last());
                }
                planReport.CreatedAt = planReport.CreatedAt.ToUniversalTime();
                EComersDBWorker dBWorker = new EComersDBWorker(eComersContext);
                await dBWorker.CreatedPlanReportAsync(planReport);

                return "create";
            }
            catch
            {
                // TO DO SAVE LOG MESSAGE
                return "error";
            }
        }

        [HttpPost]
        [Route("postcreatephoto")]
        public async Task<string> CreatePhoto(Photo photo)
        {
            try
            {
                string path = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, "UploadedFiles"));
                photo.FullFileName = Path.Combine(path, $"{photo.PhotoName}.jpg");
                photo.CreatedAt = photo.CreatedAt.ToUniversalTime();
                EComersDBWorker dBWorker = new EComersDBWorker(eComersContext);
                await dBWorker.CreatedPhotoAsync(photo);

                return "create";
            }
            catch
            {
                // TO DO SAVE LOG MESSAGE
                return "error";
            }
        }
    }
}


