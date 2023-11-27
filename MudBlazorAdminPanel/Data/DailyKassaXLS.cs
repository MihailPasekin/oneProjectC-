using ClosedXML.Excel;
using EComersObjectLib.Objects;

namespace MudBlazorAdminPanel.Data
{
    public class DailyKassaXLS
    {
        private DateTime from;
        private DateTime to;
        
        public DailyKassaXLS(DateTime _from, DateTime _to) 
        {
            from = _from;
            to = _to;
            
        }
        public byte[] Edition(DaylyReportKassa data)
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

            ws.Cell(1, 1).Value = "Подотчетное лицо";
            ws.Cell(1, 2).Value = "Приход наличными";
            ws.Cell(1, 3).Value = "Банк";
            ws.Cell(1, 4).Value = "Консигнация";
            ws.Cell(1, 5).Value = "Кредит";
            ws.Cell(1, 6).Value = "Всего";
            ws.Cell(1, 8).Value = "отчет взят с даты";
            ws.Cell(2, 8).Value = from.ToString();
            ws.Cell(1, 9).Value = "отчет взят по дату";
            ws.Cell(2, 9).Value = to.ToString();

            for (int row = 0; row < data.KassaLines.Count; row++)
            {
                // The apostrophe is to force ClosedXML to treat the date as a string
                ws.Cell(row + 2, 1).Value = data.KassaLines[row].AccountablePerson;
                ws.Cell(row + 2, 2).Value = data.KassaLines[row].Coming;
                ws.Cell(row + 2, 3).Value = data.KassaLines[row].Expense;
                ws.Cell(row + 2, 4).Value = data.KassaLines[row].Credits;
                ws.Cell(row + 2, 5).Value = data.KassaLines[row].Refund;
                ws.Cell(row + 2, 6).Value = data.KassaLines[row].Coming + data.KassaLines[row].Bank + data.KassaLines[row].Consignment+ data.KassaLines[row].Credits;
                ws.Cell(data.KassaLines.Count + 4, 1).Value = "Касса на начало дня";
                ws.Cell(data.KassaLines.Count + 4, 2).Value = data.KassaStartDay; 
                ws.Cell(data.KassaLines.Count + 5, 1).Value = "Сумма прихода";
                ws.Cell(data.KassaLines.Count + 5, 2).Value = data.KassaComming;
                ws.Cell(data.KassaLines.Count + 6, 1).Value = "Расход"; 
                ws.Cell(data.KassaLines.Count + 6, 2).Value = data.KassaExpense;
                ws.Cell(data.KassaLines.Count + 7, 1).Value = "Касса на конец дня";
                ws.Cell(data.KassaLines.Count + 7, 2).Value = data.KassaEndDay;
            }

            MemoryStream XLSStream = new();
            wb.SaveAs(XLSStream);

            return XLSStream.ToArray();
        }
    }
}
