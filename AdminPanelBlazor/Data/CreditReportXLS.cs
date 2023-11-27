using ClosedXML.Excel;
using EComersObjectLib.Objects;

namespace AdminPanelBlazor.Data
{
    public class CreditReportXLS
    {
        private string from;
        private string to;
        public CreditReportXLS(DateTime _from, DateTime _to) 
        {
            from = _from.ToString("dd.MM.yyyy");
            to = _to.ToString("dd.MM.yyyy");
        }
        public byte[] Edition(List<CreditReportLines> data)
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

            ws.Cell(1, 1).Value = "Рут";
            ws.Cell(1, 2).Value = "Агент";
            ws.Cell(1, 3).Value = "Номер документа";
            ws.Cell(1, 4).Value = "Дата Доставки";
            ws.Cell(1, 5).Value = "Клиент";
            ws.Cell(1, 6).Value = "Сумма заказа";
            ws.Cell(1, 7).Value = "Консигнация";
            ws.Cell(1, 8).Value = "Перечисление";
            ws.Cell(1, 9).Value = "Кредит 7 дней";
            ws.Cell(1, 10).Value = "Кредит 14 дней";
            ws.Cell(1, 11).Value = "Кредит 30 дней";
            ws.Cell(1, 12).Value = "Осталось дней";
            ws.Cell(1, 13).Value = "Просрочено дней";
            ws.Cell(1, 14).Value = "Сумма кредита";
            ws.Cell(1, 15).Value = "Остаток";
            ws.Cell(1, 16).Value = "Сумма оплаты";
            ws.Cell(1, 17).Value = "Сумма возрата";
            ws.Cell(1, 19).Value = "отчет взят с даты";
            ws.Cell(2, 19).Value = from.ToString();
            ws.Cell(1, 20).Value = "отчет взят по дату";
            ws.Cell(2, 20).Value = to.ToString();

            for (int row = 0; row < data.Count; row++)
            {
                // The apostrophe is to force ClosedXML to treat the date as a string
                ws.Cell(row + 2, 1).Value = data[row].Route;
                ws.Cell(row + 2, 2).Value = data[row].Agent;
                ws.Cell(row + 2, 3).Value = data[row].DocNum;
                ws.Cell(row + 2, 4).Value = data[row].DeliveriDate.ToShortDateString();
                ws.Cell(row + 2, 5).Value = data[row].Client;
                ws.Cell(row + 2, 6).Value = data[row].OrderSum;
                ws.Cell(row + 2, 7).Value = data[row].ConsignmentTotal;
                ws.Cell(row + 2, 8).Value = data[row].Transfer;
                ws.Cell(row + 2, 9).Value = data[row].Credit7;
                ws.Cell(row + 2, 10).Value = data[row].Credit14;
                ws.Cell(row + 2, 11).Value = data[row].Credit30;
                ws.Cell(row + 2, 12).Value = data[row].Ostalos;
                ws.Cell(row + 2, 13).Value = data[row].Expired;
                ws.Cell(row + 2, 14).Value = data[row].CreditSum;
                ws.Cell(row + 2, 15).Value = data[row].Balance;
                ws.Cell(row + 2, 16).Value = data[row].SumOplaty;
                ws.Cell(row + 2, 17).Value = data[row].SumVozvrat;
            }

            MemoryStream XLSStream = new();
            wb.SaveAs(XLSStream);

            return XLSStream.ToArray();
        }
    }
}
