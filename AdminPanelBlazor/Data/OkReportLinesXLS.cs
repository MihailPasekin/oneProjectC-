using ClosedXML.Excel;
using EComersObjectLib.Objects;

namespace AdminPanelBlazor.Data
{
    public class OkReportLinesXLS
    {
        private string from;
        private string to;
        private string valueTru;
        public OkReportLinesXLS(DateTime _from, DateTime _to, string _valueTry)
        {
            from = _from.ToString("dd.MM.yyyy");
            to = _to.ToString("dd.MM.yyyy");
            valueTru = _valueTry;
        }
        public byte[] Edition(List<OkReportLines> data)
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

            var ws = wb.Worksheets.Add("Weather Forecast");

            ws.Cell(1, 1).Value = "Дата заказа";
            ws.Cell(1, 2).Value = "Сумма заказа";
            ws.Cell(1, 3).Value = "Сумма продажи";
            ws.Cell(1, 4).Value = "Сумма оплаты";
            ws.Cell(1, 5).Value = "Сумма возврата";
            ws.Cell(1, 6).Value = "Всего";
            ws.Cell(1, 8).Value = "отчет взят с даты";
            ws.Cell(2, 8).Value = from.ToString();
            ws.Cell(1, 9).Value = "отчет взят по дату";
            ws.Cell(2, 9).Value = to.ToString();

            for (int row = 0; row < data.Count; row++)
            {
                // The apostrophe is to force ClosedXML to treat the date as a string
                ws.Cell(row + 2, 1).Value = "'" + data[row].DocDate.ToShortDateString();
                ws.Cell(row + 2, 2).Value = data[row].SumZakaza;
                ws.Cell(row + 2, 3).Value = data[row].SumProdaji;
                ws.Cell(row + 2, 4).Value = data[row].SumOplaty;
                ws.Cell(row + 2, 5).Value = data[row].SumVozvrat;
                ws.Cell(row + 2, 6).Value = valueTru;
            }

            MemoryStream XLSStream = new();
            wb.SaveAs(XLSStream);

            return XLSStream.ToArray();
        }
    }
}
