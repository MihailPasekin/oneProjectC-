using EComersWebApiEmploe.Services;
using Microsoft.AspNetCore.Mvc;
using EComersObjectLib.SapObjects;
using SapDBWorkerLib;
using SAPbobsCOM;
using EComersDBworkerLib;
using Newtonsoft.Json;

namespace EComersWebApiEmploe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryController : ControllerBase
    {
        EComersContext eComersContext = new EComersContext();
        EComersDBWorker dBWorker;
        public DeliveryController(EComersContext _eComersContext)
        {
            eComersContext = _eComersContext;
            dBWorker = new EComersDBWorker(eComersContext);
        }

        [Route("getsapdelivery")]
        [HttpGet]
        public async Task<ActionResult<List<ODLN>>> GetSapDeliveryByOwnerCode([FromServices] InitSapDbWorker initSapDbWorker, string code)
        {
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            if (sapDBWorker.Connected())
            {
                return await Task.Run(new Func<ActionResult<List<ODLN>>>(() => new ActionResult<List<ODLN>>(sapDBWorker.GetListSapDelivery(code))));
            };

            return new OkObjectResult(new List<ODLN>());
        }
        [Route("getsapdeliveryitem")]
        [HttpGet]
        public async Task<ActionResult<List<DeliveryItem>>> GetListSapDeliveryLines([FromServices] InitSapDbWorker initSapDbWorker, int docEntry)
        {
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            if (sapDBWorker.Connected())
            {
                return await Task.Run(new Func<ActionResult<List<DeliveryItem>>>(() => new ActionResult<List<DeliveryItem>>(sapDBWorker.GetListSapDeliveryItems(docEntry))));
            };

            return new OkObjectResult(new List<DeliveryItem>()); ;
        }
        [Route("getsapdeliveryitembyempid")]
        [HttpGet]
        public async Task<ActionResult<List<DeliveryItem>>> GetListSapDeliveryItemsByEmpId([FromServices] InitSapDbWorker initSapDbWorker, int empId)
        {
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            if (sapDBWorker.Connected())
            {
                return await Task.Run(new Func<ActionResult<List<DeliveryItem>>>(() => new ActionResult<List<DeliveryItem>>(sapDBWorker.GetListSapDeliveryItemsByEmpId(empId))));
            };

            return new OkObjectResult(new List<DeliveryItem>()); ;
        }
        [HttpPost]
        [Route("createinvoice")]
        public async Task<string> CreateInvoiceBaseOnDeliveryAsync([FromServices] InitSapDbWorker initSapDbWorker, [FromBody] DeliveryForInvoice delivery)
        {
            //DeliveryForInvoice? delivery = JsonConvert.DeserializeObject<DeliveryForInvoice>(body);
            string errorMessage = string.Empty;
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();


            //SaveDeliveryForInvoice

            if (sapDBWorker.Connected())
            {
                if (delivery != null)
                {
                    try
                    {

                        Documents invoiceDoc = sapDBWorker.company.GetBusinessObject(BoObjectTypes.oInvoices);

                        invoiceDoc.CardCode = delivery.ODLN.CardCode;
                        int index = 0;
                        foreach (var item in delivery.DeliveryItems)
                        {
                            invoiceDoc.Lines.BaseEntry = delivery.ODLN.DocEntry;
                            invoiceDoc.Lines.BaseLine = index;
                            invoiceDoc.Lines.BaseType = Convert.ToInt32(BoObjectTypes.oDeliveryNotes);

                            invoiceDoc.Lines.Add();
                            index++;
                        }

                        if (invoiceDoc.Add() == 0)
                        {
                            errorMessage = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - Invoice " + delivery.ODLN.DocEntry + " is CREATED!";
                            Console.WriteLine(errorMessage);

                            delivery.ODLN.DocDate = delivery.ODLN.DocDate.ToUniversalTime();
                            delivery.Created = DateTime.UtcNow;
                            delivery.ErrorMessage = errorMessage;
                            await dBWorker.SaveDeliveryForInvoice(delivery);
                            return "create";
                        }
                        else
                        {
                            errorMessage = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - Error adding Invoice " + delivery.ODLN.DocEntry + ": " + sapDBWorker.company.GetLastErrorCode().ToString() + " " + sapDBWorker.company.GetLastErrorDescription();
                            Console.WriteLine(errorMessage);

                            delivery.ODLN.DocDate = delivery.ODLN.DocDate.ToUniversalTime();
                            delivery.Created = DateTime.UtcNow;
                            delivery.ErrorMessage = errorMessage;
                            await dBWorker.SaveDeliveryForInvoice(delivery);
                            return "error";
                        }

                    }
                    catch (Exception ex)
                    {
                        errorMessage = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - Error adding Invoice " + delivery.ODLN.DocEntry + ": " + ex.Message;
                        Console.WriteLine(errorMessage);

                        delivery.ODLN.DocDate = delivery.ODLN.DocDate.ToUniversalTime();
                        delivery.Created = DateTime.UtcNow;
                        delivery.ErrorMessage = errorMessage;
                        await dBWorker.SaveDeliveryForInvoice(delivery);
                        return "error";
                    }
                }
                else
                {
                    errorMessage = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - There is no Invoice fetched!";
                    Console.WriteLine(errorMessage);
                    //TO DO LOG MESSAGE
                    return "error";
                }
            }
            else
            {
                Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - Cannot connect to database!");
                //TO DO LOG MESSAGE
                return "error";
            }

        }

        [HttpPost]
        [Route("createdelivery")]
        public async Task<string> CreateDeliveryAsync([FromServices] InitSapDbWorker initSapDbWorker, [FromBody] int docEntry)
        {
            string errorMessage = string.Empty;
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            ORDR order = new ORDR();


            if (sapDBWorker.Connected())
            {
                try
                {
                    order = sapDBWorker.GetSapOrderByDocEntry(docEntry);

                    if (order.DocEntry > 0)
                    {

                        Documents delivery = sapDBWorker.company.GetBusinessObject(BoObjectTypes.oDeliveryNotes);

                        delivery.CardCode = order.CardCode;
                        delivery.DocDate = order.DocDate;
                        
                        var orderLines = sapDBWorker.GetListSapOrdersLines(docEntry);
                        if (orderLines.Count > 0)
                        {
                            int index = 0;
                            foreach (var line in orderLines)
                            {
                                delivery.Lines.BaseEntry = order.DocEntry;
                                delivery.Lines.BaseType = Convert.ToInt32(BoObjectTypes.oOrders);
                                delivery.Lines.WarehouseCode = line.WhsCode;
                                delivery.Lines.Quantity = line.Quantity;
                                delivery.Lines.Price = line.Price;
                                delivery.Lines.BaseLine = index;

                                index++;
                                delivery.Lines.Add();
                            }
                        }
                        if (delivery.Add() == 0)
                        {
                            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - Delivery " + order.DocEntry + " is CREATED!");
                            return "created";
                        }
                        else
                        {
                            errorMessage = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - Error adding delivery " + order.DocEntry + ": " + sapDBWorker.company.GetLastErrorCode().ToString() + " " + sapDBWorker.company.GetLastErrorDescription();
                            Console.WriteLine(errorMessage);
                            return "error";
                        }
                    }
                    else
                    {
                        Console.WriteLine(string.Format("Date time: {0}, error: {1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), " - Order not found!"));
                        return "error";
                    }
                }
                catch (Exception ex)
                {
                    errorMessage = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - Error adding delivery " + order.DocEntry + ": " + ex.Message;
                    Console.WriteLine(errorMessage);
                    return "error"; 
                }
                
            }
            else
            {
                Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - Cannot connect to database!");
                //TO DO LOG MESSAGE
                return "error";
            }
        }
    }
}
