using EComersWebApiEmploe.Services;
using Microsoft.AspNetCore.Mvc;
using SAPbobsCOM;
using SapDBWorkerLib;
using EComersObjectLib.SapObjects;
using EComersDBworkerLib;
using EComersObjectLib.AditionalModels;

namespace EComersWebApiEmploe.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
            EComersContext eComersContext = new EComersContext();
            EComersDBWorker dBWorker; 
        public OrderController(EComersContext _eComersContext) 
        {
            eComersContext = _eComersContext;
            dBWorker = new EComersDBWorker(eComersContext);
        }

        [HttpPost]
        [Route("createorder")]
        public async Task<RequestResultOrder> CreateOrderAsync([FromServices] InitSapDbWorker initSapDbWorker, Order order)
        {
            string errorMessage = string.Empty;
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();
            List<OITM> errorOitm = new List<OITM>();
            if (sapDBWorker.Connected())
            {
                if (order != null)
                {
                    try
                    {
                        /*
                        Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - Order " + order.OrderCode + " is CREATED!");
                        return "created";
                        */
                        Documents salesOrder = sapDBWorker.company.GetBusinessObject(BoObjectTypes.oOrders);
                        salesOrder.DocNum = sapDBWorker.GetNewOrderCode();
                        salesOrder.CardCode = order.OrderClient;
                        salesOrder.PaymentGroupCode = order.GroupNum;
                        salesOrder.UserFields.Fields.Item("U_Agent").Value = sapDBWorker.GetExpeditorByRoot(int.Parse(order.OrderSeller));
                        salesOrder.UserFields.Fields.Item("U_Supervisor").Value = sapDBWorker.GetSupervisorByRoot(int.Parse(order.OrderSeller));
                        int owner = int.Parse(order.OrderSeller);
                        int slpcode = sapDBWorker.GetSlpCode(order.OrderSeller);
                        string whsCode = "YALKYM";

                        if (owner != 0)
                        {
                            salesOrder.DocumentsOwner = owner;
                            whsCode = sapDBWorker.GetWarehouseCode(owner.ToString());
                        }

                        if (slpcode != 0)
                        {
                            salesOrder.SalesPersonCode = slpcode;
                        }

                        salesOrder.DocDate = DateTime.Now;
                        salesOrder.DocDueDate = DateTime.Now.AddDays(1);
                        salesOrder.Comments = order.Comment;
                        

                        for (int j = 0; j < order.OrderItems.Count; j++)
                        {
                            int itemCount = sapDBWorker.GetItemWhsCount(order.OrderItems[j].ItemCode, whsCode);
                            if (itemCount > 0 && order.OrderItems[j].ItemCountForOrder <= itemCount)
                            {
                                salesOrder.Lines.ItemCode = order.OrderItems[j].ItemCode;
                                salesOrder.Lines.Quantity = order.OrderItems[j].ItemCountForOrder;
                                salesOrder.Lines.UnitPrice = order.OrderItems[j].Price;
                                salesOrder.Lines.WarehouseCode = whsCode;

                                if (j != order.OrderItems.Count - 1)
                                {
                                    salesOrder.Lines.Add();
                                }
                            }
                            else
                            {
                                errorOitm.Add(order.OrderItems[j]);
                                //TO DO add item to error
                            }
                        }
                        if (salesOrder.Add() == 0)
                        //if (0 == 0)
                        {
                            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - Order " + order.OrderCode + " is CREATED!");
                            order.Created = DateTime.UtcNow;
                            order.ErrorMessage = "Created";
                            await dBWorker.SaveOrderForSapServer(order);
                            return new RequestResultOrder() {Status = "create", ErrorOitmList = errorOitm } ;
                        }
                        else
                        {
                            errorMessage = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - Error adding order " + order.OrderCode + ": " + sapDBWorker.company.GetLastErrorCode().ToString() + " " + sapDBWorker.company.GetLastErrorDescription();
                            Console.WriteLine(errorMessage);
                            order.Created = DateTime.UtcNow;
                            order.ErrorMessage = errorMessage;
                            await dBWorker.SaveOrderForSapServer(order);
                            return new RequestResultOrder() { Status = "error", ErrorOitmList = errorOitm };
                        }


                    }
                    catch (Exception ex)
                    {
                        errorMessage = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - Error adding order " + order.OrderCode + ": " + ex.Message;
                        Console.WriteLine(errorMessage);
                        order.Created = DateTime.UtcNow;
                        order.ErrorMessage = errorMessage;
                        await dBWorker.SaveOrderForSapServer(order);
                        return new RequestResultOrder() { Status = "error", ErrorOitmList = errorOitm };
                    }
                }
                else
                {
                    errorMessage = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - There is no orders fetched!";
                    Console.WriteLine(errorMessage);
                    return new RequestResultOrder() { Status = "error", ErrorOitmList = errorOitm };
                    //TO DO LOG MESSAGE
                }
            }
            else
            {
                Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - Cannot connect to database!");
                //TO DO LOG MESSAGE
                return new RequestResultOrder() { Status = "error", ErrorOitmList = errorOitm };
            }
        }
    }
}

       



