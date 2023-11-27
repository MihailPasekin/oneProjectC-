using EComersDBworkerLib;
using EComersObjectLib.Objects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;
using SapDBWorkerLib;
using EComersObjectLib.SapObjects;
using EComersObjectLib;

namespace EComersWebApiEmploe.Services
{
    public class CustomerSynchronizationService
    {
        private EComersDBWorker dBWorker;
        private SapDBWorker sapDBWorker = new SapDBWorker();
        private List<OHEM> SapEmploye = new List<OHEM>();
        private List<Employe> employes = new List<Employe>();


        public CustomerSynchronizationService(EComersDBWorker eComersDBWorker) 
        {
            dBWorker = eComersDBWorker;
        }

        public void StartSynchronization(List<OCRD> OCRDlist)
        {
            foreach (OCRD ocrd in OCRDlist)
            {
                Customer ecommCustomer = dBWorker.GetCustomerBuCardCode(ocrd.CardCode);
                if(ecommCustomer.CustomerId == 0)
                {
                    Customer custoomer = new Customer()
                    {
                        CardCode = ocrd.CardCode,
                        CardName = ocrd.CardName,
                        Phone1 = ocrd.Phone1,
                        Free_Text = ocrd.Free_Text,
                        Notes = ocrd.Notes,
                        U_lat = ocrd.U_lat,
                        U_lng = ocrd.U_lng,
                        U_RouteID = ocrd.U_RouteID ?? ""
                    };

                    dBWorker.CreateCustomer(custoomer);
                }
                else
                {
                    if (!ecommCustomer.EqulsOcrd(ocrd))
                    {
                        ecommCustomer.CardName = ocrd.CardName;
                        ecommCustomer.Phone1 = ocrd.Phone1;
                        ecommCustomer.Free_Text = ocrd.Free_Text;
                        ecommCustomer.Notes = ocrd.Notes;
                        ecommCustomer.U_lat = ocrd.U_lat;
                        ecommCustomer.U_lng = ocrd.U_lng;
                        ecommCustomer.U_RouteID = ocrd.U_RouteID ?? "";
                        dBWorker.UpdateCustomer(ecommCustomer);
                    }
                }
            }
        }
    }
}
