using AdminPanelBlazor.Data;
using EComersObjectLib;
using EComersObjectLib.Objects;
using Microsoft.JSInterop;

namespace AdminPanelBlazor.Services
{
    public class ExcelService
    {
        public async Task GenerateWeatherForecastAsync(DateTime From, DateTime To, string valueTru, IJSRuntime js,List<OkReportLines> data,string filename = "export.xlsx")
        {
            var weatherForecast = new OkReportLinesXLS(From , To, valueTru);
            var XLSStream = weatherForecast.Edition(data);
            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }

        public async Task GenerateWeatherDeyliKassaAsync(DateTime From, DateTime To, IJSRuntime js,DaylyReportKassa data,string filename = "export.xlsx")
        {
            var weatherForecast = new DailyKassaXLS(From,  To);
            var XLSStream = weatherForecast.Edition(data);
            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }

        public async Task GenerateWeatherCreditReportAsync(DateTime From,DateTime To ,IJSRuntime js,List<CreditReportLines> data,string filename = "export.xlsx")
        {
            var weatherForecast = new CreditReportXLS(To, From);
            var XLSStream = weatherForecast.Edition(data);
            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }

        public async Task GenerateWeatherPercentAsync(DateTime From, DateTime To, IJSRuntime js,List<List<Percent>> data,string filename = "export.xlsx")
        {
            var weatherForecast = new PercentXLS(From , To);
            var XLSStream = weatherForecast.Edition(data);
            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }

        public async Task GenerateWeatherСonsignmentAsync(DateTime From, DateTime To ,IJSRuntime js,List<Сonsignment> data,string filename = "export.xlsx")
        {
            var weatherForecast = new ConsigmentXLS( From , To);
            var XLSStream = weatherForecast.Edition(data);
            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }

        public async Task GenerateWarehouseLoadingReportAsync(DateTime From, string employeName, IJSRuntime js,List<LoadingReport> data,string filename = "export.xlsx")
        {
            var xlsReport = new WarehouseLoadingXLS(From, employeName);
            var XLSStream = xlsReport.Edition(data);
            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task ForwarderDocListReportAsync(DateTime From, string employeName, IJSRuntime js,List<ForwarderDocList> data,string filename = "export.xlsx")
        {
            var xlsReport = new WeathForwarderDocListXLS(From, employeName);
            var XLSStream = xlsReport.Edition(data);
            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task WarehouseWithdrawalDocListReportAsync(string stock, IJSRuntime js, List<WarehouseWithdrawal> data, string filename = "export.xlsx")
        {
            var xlsReport = new WarehouseWithdrawalDocLisXLS(stock);
            var XLSStream = xlsReport.Edition(data);
            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        
        public async Task TemplateWeatherForecastAsync(IJSRuntime js,
                                                       DeliveryForReport data,
                                                       string filename = "export.xlsx")
        {
            var templateXLS = new DeliveryForReportXLS();
            var XLSStream = templateXLS.Edition(data);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }

        public async Task TemplateWeatherForecastAllDeliveryAsync(IJSRuntime js,
                                                      List<DeliveryForReport> data,
                                                      string filename = "export.xlsx")
        {
            var templateXLS = new DeliveryForReportXLS();
            var XLSStream = templateXLS.EditionAllDelvery(data);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        /*
        public async Task TemplateOnExistingFileAsync(HttpClient client,
                                                      IJSRuntime js,
                                                      Stream streamTemplate,
                                                      WeatherForecast[] data,
                                                      string existingFile)
        {
            var templateXLS = new OkReportLinesXLS();
            var XLSStream = await templateXLS.FillIn(client, streamTemplate, data, existingFile);

            await js.InvokeVoidAsync("BlazorDownloadFile", "export.xlsx", XLSStream);
        }
        */
    }
}
