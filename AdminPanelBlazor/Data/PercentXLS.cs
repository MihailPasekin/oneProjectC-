using ClosedXML.Excel;
using EComersObjectLib.Objects;

namespace AdminPanelBlazor.Data
{
    public class PercentXLS
    {
        private string from;
        private string to;
        public PercentXLS(DateTime _to , DateTime _from) 
        {
            from = _from.ToString("dd.MM.yyyy");
            to = _to.ToString("dd.MM.yyyy");
        }
        public byte[] Edition(List<List<Percent>> data)
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
            int row = 0;
            foreach (var percent in data) 
            {
                if (percent.First().JopTitle == "supervisor")
                {

                    row++;
                    ws.Cell(row + 1, 1).Value = "Супервайзер";
                    ws.Cell(row + 2, 1).Value = "Имя";
                    ws.Cell(row + 2, 2).Value = "Сумма";
                    ws.Cell(row + 2, 3).Value = "Комиссия";
                    ws.Cell(row + 2, 5).Value = "отчет взят с даты";
                    ws.Cell(row + 3, 5).Value = from.ToString();
                    ws.Cell(row + 2, 6).Value = "отчет взят по дату";
                    ws.Cell(row + 3, 6).Value = to.ToString();

                    for (int i = 0 ; i < percent.Count; i++)
                    {
                        ws.Cell(row + 3, 1).Value = percent[i].Name;
                        ws.Cell(row + 3, 2).Value = Math.Round(percent[i].Sum, 2);
                        ws.Cell(row + 3, 3).Value = Math.Round(percent[i].Commission, 2);
                        row++;
                    }
                    row += 2;
                }
                if (percent.First().JopTitle == "delivery")
                {
                    row++;
                    ws.Cell(row + 1, 1).Value = "Экспедитор";
                    ws.Cell(row + 2, 1).Value = "Код";
                    ws.Cell(row + 2, 2).Value = "Имя";
                    ws.Cell(row + 2, 3).Value = "Сумма";
                    ws.Cell(row + 2, 4).Value = "Комиссия";


                    for (int i = 0; i < percent.Count; i++)
                    {
                        ws.Cell(row + 3, 1).Value = percent[i].Code;
                        ws.Cell(row + 3, 2).Value = percent[i].Name;
                        ws.Cell(row + 3, 3).Value = Math.Round(percent[i].Sum, 2);
                        ws.Cell(row + 3, 4).Value = Math.Round(percent[i].Commission, 2);
                        row++;
                    }
                    row += 2;
                }
                if (percent.First().JopTitle == "agent")
                {
                    row++;
                    ws.Cell(row + 1, 1).Value = "Торговый агент";
                    ws.Cell(row + 2, 1).Value = "Код";
                    ws.Cell(row + 2, 2).Value = "Имя";
                    ws.Cell(row + 2, 3).Value = "Сумма";
                    ws.Cell(row + 2, 4).Value = "Комиссия";


                    for (int i = 0; i < percent.Count; i++)
                    {
                        ws.Cell(row + 3, 1).Value = percent[i].Code;
                        ws.Cell(row + 3, 2).Value = percent[i].Name;
                        ws.Cell(row + 3, 3).Value = Math.Round(percent[i].Sum, 2);
                        ws.Cell(row + 3, 4).Value = Math.Round(percent[i].Commission, 2);
                        row++;
                    }
                    row += 2; 
                }
            }

          

            

            MemoryStream XLSStream = new();
            wb.SaveAs(XLSStream);

            return XLSStream.ToArray();
        }
    }
}
