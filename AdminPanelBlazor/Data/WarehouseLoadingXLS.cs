using ClosedXML.Excel;
using EComersObjectLib.Objects;

namespace AdminPanelBlazor.Data
{
    public class WarehouseLoadingXLS
    {
        private DateTime from;
        string employeName = "";
        
        public WarehouseLoadingXLS(DateTime _from, string _employeName)
        {
            from = _from;
            employeName = _employeName;
        }
        public byte[] Edition(List<LoadingReport> data)
        {
            var wb = new XLWorkbook();
            wb.Properties.Author = "the Author";
            wb.Properties.Title = "the Title";
            wb.Properties.Subject = "the Subject";
            wb.Properties.Category = "the Category";
            wb.Properties.Keywords = "the Keywords";
            wb.Properties.Comments = "the Comments";
            wb.Properties.Status = "the Status";
            wb.Properties.LastModifiedBy = "the Last Modified By";
            wb.Properties.Company = "the Company";
            wb.Properties.Manager = "the Manager";

            var ws = wb.Worksheets.Add("Warehouse");

            ws.Cell(1, 1).Value = "Подбор товаров к отгрузке на дату:";
            ws.Cell(1, 2).Value = from.ToShortDateString();
            ws.Cell(2, 1).Value = "Экспедитор";
            ws.Cell(2, 2).Value = employeName;

            ws.Cell(4, 1).Value = "Код заказчика";
            ws.Cell(4, 2).Value = "Описаниие";
            ws.Cell(4, 3).Value = "Код товара";
            ws.Cell(4, 4).Value = "Количество";
            ws.Cell(4, 5).Value = "Дата доставки";
            ws.Cell(4, 6).Value = "Цена";
            ws.Cell(4, 7).Value = "Дата регистрации";

            int row = 0;
            double col = 0;
            for (; row < data.Count; row++)
            {
                col += data[row].Price;
                ws.Cell(row + 5, 1).Value = data[row].CardCode;
                ws.Cell(row + 5, 2).Value = data[row].Description;
                ws.Cell(row + 5, 3).Value = data[row].CodeBars;
                ws.Cell(row + 5, 4).Value = data[row].Quantity.ToString();
                ws.Cell(row + 5, 5).Value = "'" + data[row].ShipDate.ToShortDateString();
                ws.Cell(row + 5, 6).Value = data[row].Price.ToString();
                ws.Cell(row + 5, 7).Value = "'" + data[row].DocDate.ToShortDateString();
            }
          

            MemoryStream XLSStream = new();
            wb.SaveAs(XLSStream);

            return XLSStream.ToArray();
        }
    }
}
