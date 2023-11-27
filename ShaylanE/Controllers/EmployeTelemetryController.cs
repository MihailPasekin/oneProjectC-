using EComersDBworkerLib;
using EComersObjectLib.Objects;
using Microsoft.AspNetCore.Mvc;

namespace EComersWebApiEmploe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeTelemetryController : ControllerBase
    {
        private EComersContext eComersContext;

        public EmployeTelemetryController(EComersContext _eComersContext)
        {
            eComersContext = _eComersContext;
        }

        [HttpGet]
        [Route("gettelemetry")]

        public async Task<List<Telemetry>> GetTelemetryAsync(DateTime fromDate, DateTime toDate)
        {
            List<Telemetry> listTelemetry = new List<Telemetry>();
            try
            {
                EComersDBWorker dBWorker = new EComersDBWorker(eComersContext);
                listTelemetry = await dBWorker.GetTelemetryAsync(fromDate, toDate);


                return listTelemetry;
            }
            catch (Exception ex)
            {
                return new List<Telemetry>();
            }
        }

        [HttpPost]
        [Route("postcreatetelemetry")]
        public async Task<string> CreateTelemetryApiAsync(Telemetry telemetry)
        {
            try
            {
                EComersDBWorker dBWorker = new EComersDBWorker(eComersContext);
                await dBWorker.CreatedTelemetryAsync(telemetry);

                return "created";
            }
            catch
            {
                // TO DO SAVE LOG MESSAGE
                return "error";
            }
        }

        [HttpGet]
        [Route("gettelemetryempid")]
        public async Task<List<Telemetry>> GetTelemetryEmpIdAsync(int empId)
        {
            List<Telemetry> listTelemetry = new List<Telemetry>();
            try
            {
                EComersDBWorker dBWorker = new EComersDBWorker(eComersContext);
                listTelemetry = await dBWorker.GetTelemetryIdAsync(empId);


                return listTelemetry;
            }
            catch (Exception ex)
            {
                return new List<Telemetry>();
            }
        }
    }
}
