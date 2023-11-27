using EComersDBworkerLib;
using EComersObjectLib;
using Microsoft.AspNetCore.Mvc;


namespace EComersWebApiEmploe.Controllers
{
    [Route("employe")]
    [ApiController]
    public class EmployeController : ControllerBase
    {
        private EComersContext eComersContext;

        public EmployeController(EComersContext _eComersContext)
        {
            eComersContext = _eComersContext;
        }

        // GET: api/<EmployeController>
        [Route("getemployes")]
        [HttpGet]
        public async Task<ActionResult<List<EmployeView>>> GetEmployesAsync()
        {
            List<EmployeView> employeViews = new List<EmployeView>();
            try
            {
                EComersDBWorker dBWorker = new EComersDBWorker(eComersContext);
                List<Employe> employes = await dBWorker.GetEmployeListAsync();
                employes.ForEach(p => employeViews.Add(new EmployeView(p)));

                return new OkObjectResult(employeViews);
            }
            catch(Exception ex) 
            {
                return new OkObjectResult(ex);
            }
        }

        
        [Route("getemploye")]
        [HttpGet]
        public async Task<ActionResult<List<EmployeView>>> GetEmployeByIdAsync(int id)
        {
            EComersDBWorker dBWorker = new EComersDBWorker(eComersContext);
            EmployeView employeView = new EmployeView(await dBWorker.GetEmployeByIdAsync(id));
           // employes.ForEach(p => employeViews.Add(new EmployeView(p)));

            return new OkObjectResult(employeView);
        }
       

    }
}
