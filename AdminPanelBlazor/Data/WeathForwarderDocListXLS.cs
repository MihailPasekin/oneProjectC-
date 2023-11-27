using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using EComersObjectLib.Objects;

namespace AdminPanelBlazor.Data
{
    public class WeathForwarderDocListXLS
    {
        private DateTime from;
        string employeName = "";

        public WeathForwarderDocListXLS(DateTime _from, string _employeName)
        {
            from = _from;
            employeName = _employeName;
        }
        public byte[] Edition(List<ForwarderDocList> data)
        {
            double sumNal = 0;
            double sumCred = 0;
            var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("Warehouse");
            double sumDocTotal =0;
            ws.Cell(1, 1).Value = "Список документов экспедитора: ";
            ws.Cell(1, 2).Value = from.ToShortDateString();
            ws.Cell(2, 1).Value = "Экспедитор";
            ws.Cell(2, 2).Value = employeName;

            ws.Cell(4, 1).Value = "Номер Документа";
            ws.Cell(4, 2).Value = "Код клиента";
            ws.Cell(4, 3).Value = "Территория";
            ws.Cell(4, 4).Value = "Контрагент";
            ws.Cell(4, 5).Value = "Агент";
            ws.Cell(4, 6).Value = "Сумма";
            ws.Cell(4, 7).Value = "Оплата нал(+/-)";
            ws.Cell(4, 8).Value = "Отметак кассира";
            ws.Cell(4, 9).Value = "Возврат";
            ws.Cell(4, 10).Value = "Примечания";
            int row = 0;
            for (; row < data.Count; row++)
            {
                ws.Cell(row + 5, 1).Value = data[row].DocNum.ToString();
                ws.Cell(row + 5, 2).Value = data[row].CardCode;
                ws.Cell(row + 5, 3).Value = data[row].RouteID;
                ws.Cell(row + 5, 4).Value = data[row].CardName;
                ws.Cell(row + 5, 5).Value = data[row].Name;
                ws.Cell(row + 5, 6).Value = data[row].DocTotal.ToString();
                ws.Cell(row + 5, 7).Value = data[row].PayType;
                sumDocTotal = sumDocTotal + data[row].DocTotal;
            }
            ws.Cell(row + 5, 5).Value = "Итого:";
            ws.Cell(row + 5, 6).Value = sumDocTotal.ToString();
            foreach (var i in data) 
            {
                if (i.PayType.Contains("Кредит"))
                {
                    sumCred = sumCred + i.DocTotal;
                }
                else
                {
                    sumNal = sumNal + i.DocTotal;
                }
            }
            ws.Cell(row + 7, 1).Value = "Наличный расчет (ТМТ)";
            ws.Cell(row + 7, 2).Value = "Кредиты (ТМТ)";
            ws.Cell(row + 7, 3).Value = "Банк (ТМТ)";
            ws.Cell(row + 7, 4).Value = "Перенос (ТМТ)";
            ws.Cell(row + 7, 5).Value = "Возвраты (ТМТ)";
            ws.Cell(row + 7, 6).Value = "Расходы (ТМТ)";

            ws.Cell(row + 8, 1).Value = sumNal.ToString();
            ws.Cell(row + 8, 2).Value = sumCred.ToString();
            ws.Cell(row + 8, 3).Value = "0";
            ws.Cell(row + 8, 4).Value = "0";
            ws.Cell(row + 8, 5).Value = "0";
            ws.Cell(row + 8, 6).Value = "0";

            ws.Cell(row+ 11, 2).Value ="Отпустил__________";
            ws.Cell(row+ 11, 5).Value = "Получил__________";
            MemoryStream XLSStream = new();
            wb.SaveAs(XLSStream);

            return XLSStream.ToArray();
        }
    }
}
