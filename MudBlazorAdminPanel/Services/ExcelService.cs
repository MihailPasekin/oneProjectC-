using MudBlazorAdminPanel.Data;
using EComersObjectLib;
using EComersObjectLib.Objects;
using Microsoft.JSInterop;

namespace MudBlazorAdminPanel.Services
{
    public class ExcelService
    {
        public async Task GenerateWeatherForecastAsync(DateTime From, DateTime To, string valueTru, IJSRuntime js,
                                                  List<OkReportLines> data,
                                                  string filename = "export.xlsx")
        {
            var weatherForecast = new OkReportLinesXLS(From , To, valueTru);
            var XLSStream = weatherForecast.Edition(data);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task GenerateWeatherDeyliKassaAsync(DateTime From, DateTime To, IJSRuntime js,
                                                  DaylyReportKassa data,
                                                  string filename = "export.xlsx")
        {
            var weatherForecast = new DailyKassaXLS(From,  To);
            var XLSStream = weatherForecast.Edition(data);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }

        public async Task GenerateWeatherCreditReportAsync(DateTime From,DateTime To ,IJSRuntime js,
                                                  List<CreditReportLines> data,
                                                  string filename = "export.xlsx")
        {
            var weatherForecast = new CreditReportXLS(To, From);
            var XLSStream = weatherForecast.Edition(data);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task GenerateWeatherPercentAsync(DateTime From, DateTime To, IJSRuntime js,
                                                 List<List<Percent>> data,
                                                  string filename = "export.xlsx")
        {
            var weatherForecast = new PercentXLS(From , To);
            var XLSStream = weatherForecast.Edition(data);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        public async Task GenerateWeatherСonsignmentAsync(DateTime From, DateTime To ,IJSRuntime js,
                                                 List<Сonsignment> data,
                                                  string filename = "export.xlsx")
        {
            var weatherForecast = new ConsigmentXLS( From , To);
            var XLSStream = weatherForecast.Edition(data);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }
        /*
        public async Task TemplateWeatherForecastAsync(IJSRuntime js,
                                                       Stream streamTemplate,
                                                       WeatherForecast[] data,
                                                       string filename = "export.xlsx")
        {
            var templateXLS = new OkReportLinesXLS();
            var XLSStream = templateXLS.Edition(streamTemplate, data);

            await js.InvokeVoidAsync("BlazorDownloadFile", filename, XLSStream);
        }


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
