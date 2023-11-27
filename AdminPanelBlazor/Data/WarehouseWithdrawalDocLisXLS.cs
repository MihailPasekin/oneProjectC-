using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing.Charts;
using EComersObjectLib.Objects;

namespace AdminPanelBlazor.Data
{
    public class WarehouseWithdrawalDocLisXLS
    {
        string stock;
        public WarehouseWithdrawalDocLisXLS(string _stock) 
        {
            stock = _stock;
        }
        public byte[] Edition(List<WarehouseWithdrawal> data)
        {
            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Rich Text");
  
         
            var rich = ws.Cell(10, 10).CreateRichText();
            rich.AddText("Test").Bold = true;

            ws.Cell(1, 1).Value = stock;
            ws.Cell(2, 1).Value = "Код";
            ws.Cell(2, 2).Value = "Имя продукта";
            ws.Cell(2, 3).Value = "Количество на складе";
            ws.Cell(2, 4).Value = "Продажа(заказанно)";
            ws.Cell(2, 5).Value = "Закупки(заказанно)";
            

            for (int row = 0; row < data.Count; row++)
            {
                ws.Cell(row + 3, 1).Value = data[row].ItemCode;
                ws.Cell(row + 3, 2).Value = data[row].ItemName;
                ws.Cell(row + 3, 3).Value = data[row].OnHand;
                ws.Cell(row + 3, 4).Value = data[row].IsCommited;
                ws.Cell(row + 3, 5).Value = data[row].IsCommited;
            }
            
            MemoryStream XLSStream = new();
            wb.SaveAs(XLSStream);

            return XLSStream.ToArray();
        }

        public byte[] OLDEdition(List<WarehouseWithdrawal> data)
        {
            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Warehouse");

            ws.Cell(1, 1).Value = stock;
            ws.Cell(2, 1).Value = "Код";
            ws.Cell(2, 2).Value = "Имя продукта";
            ws.Cell(2, 3).Value = "Количество на складе";
            ws.Cell(2, 4).Value = "Продажа(заказанно)";
            ws.Cell(2, 5).Value = "Закупки(заказанно)";

            for (int row = 0; row < data.Count; row++)
            {
                ws.Cell(row + 3, 1).Value = data[row].ItemCode;
                ws.Cell(row + 3, 2).Value = data[row].ItemName;
                ws.Cell(row + 3, 3).Value = data[row].OnHand;
                ws.Cell(row + 3, 4).Value = data[row].IsCommited;
                ws.Cell(row + 3, 5).Value = data[row].IsCommited;
            }

            MemoryStream XLSStream = new();
            wb.SaveAs(XLSStream);

            return XLSStream.ToArray();
        }
    }
}
