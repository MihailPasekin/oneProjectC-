
using SapDBWorkerLib;
using EComersObjectLib.SapObjects;
//using static System.Runtime.InteropServices.JavaScript.JSType;
using SAPbobsCOM;
using EComersObjectLib;
using ScExpertDbLib;
using System.ComponentModel.Design.Serialization;
using EComersDBworkerLib;
/*
var sapDBWorker = new SapDBWorker();
sapDBWorker.Connect();
*/
/*
if (sapDBWorker.Connected())
{
    Recordset recordset = sapDBWorker.company.GetBusinessObject(BoObjectTypes.BoRecordset);
    recordset.DoQuery($"select \"DocEntry\", \r\n\"DocNum\", \r\n\"DocStatus\", \r\n\"DocDate\",\r\n\"DocTime\", \r\n\"CardCode\", \r\n\"CardName\", \r\n\"DocTotal\", \r\n\"GrosProfit\", \r\n\"OwnerCode\" ,\r\n\"GroupNum\",\r\n(CASE WHEN \"GroupNum\"='-1' THEN 'Cash'\r\n  WHEN \"GroupNum\"='1' OR \"GroupNum\"='2' OR \"GroupNum\"='3' OR \"GroupNum\"='4'  THEN 'Credit'\r\n  WHEN \"GroupNum\"='5' THEN 'Bank'\r\n  WHEN \"GroupNum\"='6' THEN 'Consignment'\r\n  END) AS \"PayType\"\r\nfrom TEST.ORDR where \"OwnerCode\" = 1230 limit 1;");
    List<object> ORDRlist = new List<object>();

    sapDBWorker.Disconnect();

    while (!recordset.EoF)
    {
        ORDR oRDR = new ORDR()
        {
            DocEntry = (int)recordset.Fields.Item("DocEntry").Value,
            DocNum = recordset.Fields.Item("DocNum").Value,
            DocStatus = recordset.Fields.Item("DocStatus").Value,
            DocDate = ConcateDodate(recordset.Fields.Item("DocDate").Value, recordset.Fields.Item("DocTime").Value),
            CardCode = recordset.Fields.Item("CardCode").Value,
            CardName = recordset.Fields.Item("CardName").Value,
            DocTotal = (double)recordset.Fields.Item("DocTotal").Value,
            GrosProfit = (double)recordset.Fields.Item("GrosProfit").Value,
            OwnerCode = recordset.Fields.Item("OwnerCode").Value,
            GroupNum = (int)recordset.Fields.Item("GroupNum").Value,
            PayType = recordset.Fields.Item("PayType").Value
        };
        ORDRlist.Add(oRDR);
        recordset.MoveNext();
    }
}




DateTime ConcateDodate(dynamic date, dynamic time)
{
    int intTime = time;
    string strDate = date.ToString();
    string strTime = intTime.ToString();
        
    string houre = strTime.Length == 4 ? strTime.Substring(0, 2) : '0' + strTime.Substring(0, 1);
    string minute = strTime.Length == 4 ? strTime.Substring(2, 2) : strTime.Substring(1, 2);
    
    DateTime dateTime = DateTime.Parse(string.Format("{0} {1}:{2}:00.0", strDate.Remove(10, strDate.Length - 10), houre, minute));
    return dateTime;
}
*/
/*
CustomMerch CustomMerch = new CustomMerch()
{
    Name = "1",
    Code = "1",
    VisitId = 1,
    EmpID = 1,
    Created = DateTime.Now,
    CardCode = "1",
    Comment = "1",
};
*/
//int  i = sapDBWorker.CreateMerchVisit(CustomMerch);
//List<CustomMerch> CustomMerch = sapDBWorker.GetMerchVisit(0);
//CustomMerch.ForEach(x => Console.WriteLine($"{x.Name}, {x.Created}"));
//int CustomMerch = sapDBWorker.CustomMerchVIVI();
/*Console.WriteLine();
var i = sapDBWorker.GetMerchListGroup();
i.ForEach(x => Console.WriteLine( x.Name));    */


//Console.WriteLine(i);
/*
using (ScexpertContext db = new ScexpertContext())
{
    // получаем объекты из бд и выводим на консоль
    var order = db.Outboundorheaders.Where(p=>p.Referenceord == "32874").First();
    Console.WriteLine("Список объектов:");
    
    Console.WriteLine($"{order.Orderid}.{order.Referenceord} - {order.Status}");
    
}
*/
/*
if (sapDBWorker.Connected())
{
   Console.WriteLine( sapDBWorker.GetWarehouseCode(1285));
}

string root = "ROOT # 05 AG";
Console.WriteLine(root.Trim().ToUpper().Substring(root.Length - 2, 2));
*/
var dbWorker = new EComersDBWorker(new EComersContext());
Employe employe = dbWorker.GetEmployeByEmpIdAsync(1230);

EmployeHistory employeHistory = employe.GetActualEmployeHistory();
if (employeHistory != null)
{
    EmployeHistory newEmployeHistory = new(employeHistory)
    {
        Name = "Test7",
        SecondName = "TestSeconName7",
        StartDate = DateTime.UtcNow,
        EndDate = DateTime.MaxValue,
    };

    dbWorker.UpdateEmploye(employe, newEmployeHistory);

    Console.WriteLine(employe.ToString());
}


Console.ReadKey();