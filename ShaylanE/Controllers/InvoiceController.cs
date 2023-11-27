using EComersWebApiEmploe.Services;
using Microsoft.AspNetCore.Mvc;
using SAPbobsCOM;
using SapDBWorkerLib;
using EComersObjectLib.SapObjects;

namespace EComersWebApiEmploe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : Controller
    {
        [Route("getinvoicebyowner")]
        [HttpGet]
        public async Task<ActionResult<object>> GetInvoiceByOwnerAsync([FromServices] InitSapDbWorker initSapDbWorker, int code)
        {
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            try
            {
                if (sapDBWorker.Connected())
                {
                    return await Task.Run(new Func<ActionResult<object>>(() => new ActionResult<object>(sapDBWorker.GetListInvoice(code))));
                };

                return new OkObjectResult("Connection false");
            }
            catch (Exception ex)
            {
                return new OkObjectResult(ex);
            }
        }

        [Route("getinvoicebyexpeditor")]
        [HttpGet]
        public async Task<ActionResult<object>> GetInvoiceByExpeditorAsync([FromServices] InitSapDbWorker initSapDbWorker, string uAgent)
        {
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            try
            {
                if (sapDBWorker.Connected())
                {
                    return await Task.Run(new Func<ActionResult<object>>(() => new ActionResult<object>(sapDBWorker.GetListInvoiceByExpeditor(uAgent))));
                };

                return new OkObjectResult("Connection false");
            }
            catch (Exception ex)
            {
                return new OkObjectResult(ex);
            }
        }

        [Route("getinvoicebydocnumber")]
        [HttpGet]
        public async Task<ActionResult<object>> GetInvoiceByDocNumberAsync([FromServices] InitSapDbWorker initSapDbWorker, string docnumber)
        {
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            try
            {
                if (sapDBWorker.Connected())
                {
                    return await Task.Run(new Func<ActionResult<object>>(() => new ActionResult<object>(sapDBWorker.GetListInvoiceByDocNumber(docnumber))));
                };

                return new OkObjectResult("Connection false");
            }
            catch (Exception ex)
            {
                return new OkObjectResult(ex);
            }
        }

        [Route("getsapinvoicelines")]
        [HttpGet]
        // GET: SapOrderController/Edit/5
        public async Task<ActionResult<List<RDR1>>> GetListSapInvoiceLines([FromServices] InitSapDbWorker initSapDbWorker, int docEntry)
        {
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            if (sapDBWorker.Connected())
            {
                return await Task.Run(new Func<ActionResult<List<RDR1>>>(() => new ActionResult<List<RDR1>>(sapDBWorker.GetListSapInvoiceLines(docEntry))));
            };

            return View();
        }



        [HttpPost]
        [Route("createpayment")]
        public async Task<string> CreatePaymentAsync([FromServices] InitSapDbWorker initSapDbWorker, OINV invoice)
        {
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            if (sapDBWorker.Connected())
            {
                if (invoice != null)
                {
                    try
                    {
                        Payments incomePayment = sapDBWorker.company.GetBusinessObject(BoObjectTypes.oIncomingPayments);
                        incomePayment.Invoices.DocEntry = invoice.DocEntry;
                        incomePayment.CardCode = invoice.CardCode;
                        incomePayment.DocDate = invoice.DocDate;
                        incomePayment.DocTypte = BoRcptTypes.rCustomer;
                        incomePayment.CashSum = invoice.PaySum;
                        incomePayment.CashAccount = invoice.CashAccount;

                        if (incomePayment.Add() == 0)
                        {
                            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - Payment " + invoice.DocNum + " is CREATED!");
                            return "created";
                        }
                        else
                        {
                            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - Error adding payment " + invoice.DocNum + ": " + sapDBWorker.company.GetLastErrorCode().ToString() + " " + sapDBWorker.company.GetLastErrorDescription());
                            return "error";
                        }

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - Error adding payment " + invoice.DocNum + ": " + ex.Message);
                        return "error";
                    }
                }
                else
                {
                    Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - There is no payment fetched!");
                    return "error";
                }
            }
            else
            {
                Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - Cannot connect to database!");
                return "error";
            }
        }
    }
}


