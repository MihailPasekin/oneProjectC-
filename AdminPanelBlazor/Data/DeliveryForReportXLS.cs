using EComersObjectLib.Objects;
using ClosedXML.Excel;
using ClosedXML.Report;
using System.Diagnostics;

namespace AdminPanelBlazor.Data
{
    public class DeliveryForReportXLS
    {
        public byte[] Edition(DeliveryForReport data)
        {
            var template = new XLTemplate(".\\wwwroot\\xls\\facturadeliveri.xlsx");

            template.AddVariable(data);
            template.Generate();
            template.Workbook.TryGetWorksheet("Лист1", out IXLWorksheet worksheet);
            
            var wb = new XLWorkbook();
            
            worksheet.Name = "TEST";
            
            wb.AddWorksheet(worksheet);
            


            MemoryStream XLSStream = new();
            wb.SaveAs(XLSStream);

            return XLSStream.ToArray();
        }

        public byte[] EditionAllDelvery(List<DeliveryForReport> data)
        {

            var wb = new XLWorkbook();


            foreach (var i in data)
            {
                if (i is not null)
                {
                    var template = new XLTemplate(".\\wwwroot\\xls\\facturadeliveri.xlsx");
                    template.AddVariable(i);
                    template.Workbook.TryGetWorksheet($"Лист1", out IXLWorksheet worksheet);
                    template.Generate();
                    worksheet.CopyTo(wb, $"{i.DocNum}");
                }
            }
            MemoryStream XLSStream = new();
            wb.SaveAs(XLSStream);
            return XLSStream.ToArray();
        }
    }
}
