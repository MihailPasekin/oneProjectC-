using EComersDBworkerLib;
using EComersObjectLib.Objects;
using Microsoft.Extensions.Configuration;
using SapDBWorkerLib;
using EComersObjectLib.SapObjects;
using ScExpertDbLib;

namespace EComersWebApiEmploe.Services
{
    public class InitSapDbWorker
    {
        private IConfiguration configuration;
        private SapDBWorker sapDBWorker;
        private List<OCRD> OCRDlist = new List<OCRD>();
        private EComersDBWorker dBWorker;
        private ScExpertDbWorker scExpertDbWorker;
        


        public InitSapDbWorker(IConfiguration configuration)
        {
            this.configuration = configuration;
            dBWorker = new EComersDBWorker(new EComersContext());
            InitSap();

            StartSynchronization();
        }

       

        public void InitSap()
        {
            if (configuration == null) { return; }

            sapDBWorker = new SapDBWorker();
            sapDBWorker.Connect();

            scExpertDbWorker = new ScExpertDbWorker();

            //SapConfig sapConfig = new SapConfig(configuration);

            //sapDBWorker.SetSapConnectonOption(sapConfig.Server, sapConfig.SLDServer, sapConfig.DbServerType, sapConfig.LicenseServer, sapConfig.CompanyDB, sapConfig.UserName, sapConfig.Password, sapConfig.DbUserName, sapConfig.DbPassword, sapConfig.language, sapConfig.UseTrusted);
        }
        
        /*private void StartSinhronization()
        {
            EComersDBWorker eComersDBWorker = new EComersDBWorker(new EComersContext());
            
            //employeSynchronization.StartSinhronization();
        }
        */
        private void StartSynchronization()
        {
            Parameter param = dBWorker!.GetParameterByName("LastSynchDate").Result;
            Task.Run(() => {
                DateTime lastScExpertSynh = DateTime.Now;
                while (true)
                {
                    if (DateTime.Now > lastScExpertSynh.AddMinutes(5))
                    {
                        List<ORDR> ordrs = new List<ORDR>();
                        if (sapDBWorker.Connected())
                        {
                            ordrs = sapDBWorker.GetListAllCanceledSapOrders();
                            if (ordrs.Count > 0)
                            {
                                ordrs.ForEach(p => {
                                    scExpertDbWorker.UpdateOrderStatus(p.DocEntry);
                                });
                            }
                        }
                        lastScExpertSynh = DateTime.Now;
                    }

                    if (param.ParamName == string.Empty)
                    {
                        param.ParamName = "LastSynchDate";
                        param.DateTimeVal = DateTime.UtcNow;

                        dBWorker.CreateParametr(param);
                    }
                    else
                    {
                        if (param.DateTimeVal.Date.AddDays(1).AddHours(7) < DateTime.Now)
                        {
                            //sapDBWorker.Connect();
                            if (sapDBWorker.Connected())
                            {
                                OCRDlist = sapDBWorker.GetListCustomers();
                               // sapDBWorker.Disconnect();
                                if (OCRDlist.Count > 0)
                                {
                                    param.DateTimeVal = DateTime.UtcNow;
                                    dBWorker.UpdateParameter(param).Wait(20000);

                                    CustomerSynchronizationService customerSynchronizationService = new CustomerSynchronizationService(dBWorker);
                                    customerSynchronizationService.StartSynchronization(OCRDlist);

                                    
                                }
                                EmployeSynchronizationService employeSynchronization = new EmployeSynchronizationService(dBWorker, sapDBWorker);
                                employeSynchronization.StartSinhronization();
                            }
                        }
                    }
                    Thread.Sleep(60000);
                }

            });
        }

        public List<OCRD> GetCustomerList()
        {
            if (OCRDlist.Count == 0)
            {
                foreach (Customer customer in dBWorker.GetCustomersAsync().Result)
                {
                    OCRD ocrd = new OCRD() {
                        CardCode=customer.CardCode,
                        CardName=customer.CardName,
                        Phone1 = customer.Phone1,
                        Free_Text = customer.Free_Text,
                        Notes = customer.Notes,
                        U_lat = customer.U_lat,
                        U_lng = customer.U_lng,
                        U_RouteID = customer.U_RouteID
                    };

                    OCRDlist.Add(ocrd);
                }

               return OCRDlist;
            }
            return OCRDlist;
        }

        public List<OCRD> GetCustomerListByEmploye(int empId)
        {
            List<OCRD> OCRDtemplist = new List<OCRD>();
            List<EmployeRoot> root = new List<EmployeRoot>();
            if (sapDBWorker.Connected())
            {
                root = sapDBWorker.GetSapEmployeRoot(empId);
            }

            
            foreach (Customer customer in dBWorker.GetCustomersByRootAsync(root).Result)
            {
                OCRD ocrd = new OCRD()
                {
                    CardCode = customer.CardCode,
                    CardName = customer.CardName,
                    Phone1 = customer.Phone1,
                    Free_Text = customer.Free_Text,
                    Notes = customer.Notes,
                    U_lat = customer.U_lat,
                    U_lng = customer.U_lng,
                    U_RouteID = customer.U_RouteID
                };

                OCRDtemplist.Add(ocrd);
            }

                
            
            return OCRDtemplist;
        }

        public SapDBWorker GetSapDBWorker() { return sapDBWorker; }

        internal void StartSynh()
        {
            try
            {
                Task.Run(() =>
                {
                    if (sapDBWorker.Connected())
                    {
                        OCRDlist = sapDBWorker.GetListCustomers();
                        
                        CustomerSynchronizationService customerSynchronizationService = new CustomerSynchronizationService(dBWorker);
                        customerSynchronizationService.StartSynchronization(OCRDlist);
                        
                        EmployeSynchronizationService employeSynchronization = new EmployeSynchronizationService(dBWorker, sapDBWorker);
                        employeSynchronization.StartSinhronization();
                    }
                });
            }
            catch (Exception ex)
            {

            }
        }
    }
}
