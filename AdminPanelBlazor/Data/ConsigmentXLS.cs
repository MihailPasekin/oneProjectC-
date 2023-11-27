using ClosedXML.Excel;
using EComersObjectLib;
using EComersObjectLib.Objects;

namespace AdminPanelBlazor.Data
{
    public class ConsigmentXLS
    {
        private string from;
        private string to;
        public ConsigmentXLS(DateTime _from, DateTime _to) {
            from = _from.ToString("dd.MM.yyyy");
            to = _to.ToString("dd.MM.yyyy");
        }
        public byte[] Edition(List<Сonsignment> data)
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
            
            ws.Cell(1, 1).Value = "Id";
            ws.Cell(1, 2).Value = "Номер квитанции";
            ws.Cell(1, 3).Value = "Дата чека";
            ws.Cell(1, 4).Value = "Код продукта";
            ws.Cell(1, 5).Value = "Наименование товара";
            ws.Cell(1, 6).Value = "Количество в начале";
            ws.Cell(1, 7).Value = "Период поступления";
            ws.Cell(1, 8).Value = "Период возврата";
            ws.Cell(1, 9).Value = "Количество в конце";
            ws.Cell(1, 10).Value = "Продажи";
            ws.Cell(1, 11).Value = "Rec Price";
            ws.Cell(1, 12).Value = "Комиссионное вознаграждение";
            ws.Cell(1, 13).Value = "Оплата Основной сумма";
            ws.Cell(1, 14).Value = "Стоимость входного билета";
            ws.Cell(1, 15).Value = "Начальная сумма (Прибытие Цены)";
            ws.Cell(1, 16).Value = "Начальная сумма (Цены)";
            ws.Cell(1, 17).Value = "Квитанция cумма (Цены)";
            ws.Cell(1, 18).Value = "Квитанция сумма (Рекомендуемая Цена)";
            ws.Cell(1, 19).Value = "Сумма (Конец Цены)";
            ws.Cell(1, 20).Value = "Сумма (Конец Продаж Цена)";
            ws.Cell(1, 22).Value = "отчет взят с даты";
            ws.Cell(2, 22).Value = from.ToString();
            ws.Cell(1, 23).Value = "отчет взят по дату";
            ws.Cell(2, 23).Value = to.ToString();

            int sumQuantityAtStart = 0;
            int sumReceiptsPeriod = 0;
            int sumReturnsPeriod = 0;
            int sumQuantityAtEnd = 0;
            int sumSales = 0;
            double sumRecPrice = 0;
            double sumCommissionRemuneration = 0;
            double sumPaymentPrincipal = 0;
            double sumAdmissionPrice = 0;
            double sumStartingAmountArrivalPrice = 0;
            double sumStartingAmountPriceDetails = 0;
            double sumReceiptAmountArrivalPrice = 0;
            double sumReceiptAmountRecommendedPrice = 0;
            double sumAmountEndEntryPrice = 0;
            double sumAmountEndSellingPrice = 0;

            for (int row = 0; row < data.Count; row++)
            {
                // The apostrophe is to force ClosedXML to treat the date as a string
                ws.Cell(row + 2, 1).Value = "'" + data[row].IdReceipts;
                ws.Cell(row + 2, 2).Value = data[row].ReceiptNumber;
                ws.Cell(row + 2, 3).Value = data[row].ReceiptDate.ToShortDateString();
                ws.Cell(row + 2, 4).Value = data[row].ProductCode;
                ws.Cell(row + 2, 5).Value = data[row].ProductName;
                ws.Cell(row + 2, 6).Value = data[row].QuantityAtStart;
                ws.Cell(row + 2, 7).Value = data[row].ReceiptsPeriod;
                ws.Cell(row + 2, 8).Value = data[row].ReturnsPeriod;
                ws.Cell(row + 2, 9).Value = data[row].QuantityAtEnd;
                ws.Cell(row + 2, 10).Value = data[row].Sales;
                ws.Cell(row + 2, 11).Value = data[row].RecPrice;
                ws.Cell(row + 2, 12).Value = data[row].CommissionRemuneration;
                ws.Cell(row + 2, 13).Value = data[row].PaymentPrincipal;
                ws.Cell(row + 2, 14).Value = data[row].AdmissionPrice;
                ws.Cell(row + 2, 15).Value = data[row].StartingAmountArrivalPrice;
                ws.Cell(row + 2, 16).Value = data[row].StartingAmountPriceDetails;
                ws.Cell(row + 2, 17).Value = data[row].ReceiptAmountArrivalPrice;
                ws.Cell(row + 2, 18).Value = data[row].ReceiptAmountRecommendedPrice;
                ws.Cell(row + 2, 19).Value = data[row].AmountEndEntryPrice;
                ws.Cell(row + 2, 20).Value = data[row].AmountEndSellingPrice;

                sumQuantityAtStart += data[row].QuantityAtStart;
                sumReceiptsPeriod += data[row].ReceiptsPeriod;
                sumReturnsPeriod += data[row].ReturnsPeriod;
                sumQuantityAtEnd += data[row].QuantityAtEnd;
                sumSales += data[row].Sales;
                sumRecPrice += data[row].RecPrice;
                sumCommissionRemuneration += data[row].CommissionRemuneration;
                sumPaymentPrincipal += data[row].PaymentPrincipal;
                sumAdmissionPrice += data[row].AdmissionPrice;
                sumStartingAmountArrivalPrice += data[row].StartingAmountArrivalPrice;
                sumStartingAmountPriceDetails += data[row].StartingAmountPriceDetails;
                sumReceiptAmountArrivalPrice += data[row].ReceiptAmountArrivalPrice;
                sumReceiptAmountRecommendedPrice += data[row].ReceiptAmountRecommendedPrice;
                sumAmountEndEntryPrice += data[row].AmountEndEntryPrice;
                sumAmountEndSellingPrice += data[row].AmountEndSellingPrice;
            }
            ws.Cell(data.Count + 2, 5).Value = "Итого:";
            ws.Cell(data.Count + 2, 6).Value = sumQuantityAtStart;
            ws.Cell(data.Count + 2, 7).Value = sumReceiptsPeriod;
            ws.Cell(data.Count + 2, 8).Value = sumReturnsPeriod;
            ws.Cell(data.Count + 2 , 9).Value = sumQuantityAtEnd;
            ws.Cell(data.Count + 2, 10).Value = sumSales;
            ws.Cell(data.Count + 2, 11).Value = sumRecPrice;
            ws.Cell(data.Count + 2, 12).Value = sumCommissionRemuneration;
            ws.Cell(data.Count + 2, 13).Value = sumPaymentPrincipal;
            ws.Cell(data.Count + 2, 14).Value = sumAdmissionPrice;
            ws.Cell(data.Count + 2, 15).Value = sumStartingAmountArrivalPrice;
            ws.Cell(data.Count + 2, 16).Value = sumStartingAmountPriceDetails;
            ws.Cell(data.Count + 2, 17).Value = sumReceiptAmountArrivalPrice;
            ws.Cell(data.Count + 2, 18).Value = sumReceiptAmountRecommendedPrice;
            ws.Cell(data.Count + 2, 19).Value = sumAmountEndEntryPrice;
            ws.Cell(data.Count + 2, 20).Value = sumAmountEndSellingPrice;
            ws.Cell(data.Count + 4, 1).Value = "Сумма задолженности по оплате:";
            ws.Cell(data.Count + 4, 2).Value = 0;
            ws.Cell(data.Count + 5, 1).Value = "Сумма реализации ТОВАРОВ КОМИТЕНТА за отчетный период составила";
            ws.Cell(data.Count + 5, 2).Value = sumCommissionRemuneration + sumPaymentPrincipal;
            ws.Cell(data.Count + 6, 1).Value = "Сумма вознаграждения КОМИССИОНЕРА:";
            ws.Cell(data.Count + 6, 2).Value = sumCommissionRemuneration;
            ws.Cell(data.Count + 7, 1).Value = "Сумма причитающаяся КОМИТЕНТУ за вычетом вознаграждения КОМИССИОНЕРА:";
            ws.Cell(data.Count + 7, 2).Value = sumPaymentPrincipal;
            ws.Cell(data.Count + 8, 1).Value = "Сумма выплаты КОМИТЕНТУ за отчётный период:";
            ws.Cell(data.Count + 8, 2).Value = 0; 
            ws.Cell(data.Count + 8, 1).Value = "Сумма задолженности по оплате:";
            ws.Cell(data.Count + 8, 2).Value = 0 + sumPaymentPrincipal - 0;
            MemoryStream XLSStream = new();
            wb.SaveAs(XLSStream);

            return XLSStream.ToArray();
        }
    }
}
