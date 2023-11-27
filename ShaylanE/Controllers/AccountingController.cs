using EComersObjectLib.Objects;
using EComersObjectLib;
using EComersWebApiEmploe.Services;
using Microsoft.AspNetCore.Mvc;
using SapDBWorkerLib;
using System.Collections.Generic;

namespace EComersWebApiEmploe.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountingController : Controller
    {
        [Route("getdaylykassareport")]
        [HttpGet]
        public async Task<DaylyReportKassa> GetDeylyReportKassaAsync([FromServices] InitSapDbWorker initSapDbWorker, DateTime fromDate, DateTime toDate, string kassa)
        {
            DaylyReportKassa dailyReportKassa = new DaylyReportKassa();
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            try
            {
                if (sapDBWorker.Connected())
                {
                    dailyReportKassa = await Task.Run(new Func<DaylyReportKassa>(() => sapDBWorker.GetKassaStartEndDay(fromDate, toDate, kassa)));
                    dailyReportKassa.KassaLines = await Task.Run(new Func<List<DaylyReportKassaLines>>(() => sapDBWorker.GetDeylyReportKassa(fromDate,toDate,kassa)));
                };

                return dailyReportKassa;
            }
            catch (Exception ex)
            {
                return dailyReportKassa;
            }
        }
        [Route("geterrorpayments")]
        [HttpGet]
        public async Task<List<ErrorOrct>> GetErrorPaymentAsync([FromServices] InitSapDbWorker initSapDbWorker)
        {
            List<ErrorOrct> orcterrors = new List<ErrorOrct>();
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            try
            {
                if (sapDBWorker.Connected())
                {
                    orcterrors = await Task.Run(new Func<List<ErrorOrct>>(() => sapDBWorker.GetListOrctErrors()));
                };

                return orcterrors;
            }
            catch (Exception ex)
            {
                return orcterrors;
            }
        }
        [Route("getlistcashaccounts")]
        [HttpGet]
        public async Task<List<CashAccount>> GetListCashAccountsAsync([FromServices] InitSapDbWorker initSapDbWorker)
        {
            List<CashAccount> cashAccounts = new List<CashAccount>();
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            try
            {
                if (sapDBWorker.Connected())
                {
                    return await Task.Run(new Func<List<CashAccount>>(() => sapDBWorker.GetListCashAccounts()));
                };

                return cashAccounts;
            }
            catch (Exception ex)
            {
                return cashAccounts;
            }
        }

        [Route("getokreportlist")]
        [HttpGet]
        public async Task<List<OkReportLines>> GetOkReportListAsync([FromServices] InitSapDbWorker initSapDbWorker, DateTime fromDate, DateTime toDate)
        {
            List<OkReportLines> okReportKassa = new List<OkReportLines>();
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            try
            {
                if (sapDBWorker.Connected())
                {
                    
                    okReportKassa = await Task.Run(new Func<List<OkReportLines>>(() => sapDBWorker.GetOkReport(fromDate, toDate)));
                };

                return okReportKassa;
            }
            catch (Exception ex)
            {
                return okReportKassa;
            }
        }

        [Route("getokreportdetails")]
        [HttpGet]
        public async Task<List<OkReportDetals>> GetOkReportDetailsAsync([FromServices] InitSapDbWorker initSapDbWorker, DateTime fromDate)
        {
            List<OkReportDetals> okReportDetails = new List<OkReportDetals>();
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            try
            {
                if (sapDBWorker.Connected())
                {

                    okReportDetails = await Task.Run(new Func<List<OkReportDetals>>(() => sapDBWorker.GetOkReportDeteils(fromDate)));
                };

                return okReportDetails;
            }
            catch (Exception ex)
            {
                return okReportDetails;
            }
        }

        [Route("getcreditreportlist")]
        [HttpGet]
        public async Task<List<CreditReportLines>> GetCreditReportListAsync([FromServices] InitSapDbWorker initSapDbWorker, DateTime fromDate, DateTime toDate, string root)
        {
            List<CreditReportLines> okReportKassa = new List<CreditReportLines>();
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            try
            {
                if (sapDBWorker.Connected())
                {

                    okReportKassa = await Task.Run(new Func<List<CreditReportLines>>(() => sapDBWorker.GetCreditReportLines(fromDate, toDate, root)));
                };

                return okReportKassa;
            }
            catch (Exception ex)
            {
                return okReportKassa;
            }
        }
        [Route("geturouteid")]
        [HttpGet]
        public async Task<List<URouteID>> GetURouteIDAsync([FromServices] InitSapDbWorker initSapDbWorker, string region)
        {
            List<URouteID> uRouteID = new List<URouteID>();
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();
            
            try
            {
                if (sapDBWorker.Connected())
                {

                    uRouteID = await Task.Run(new Func<List<URouteID>>(() => sapDBWorker.GetURouteID(region)));
                };

                return uRouteID;
            }
            catch (Exception ex)
            {
                return uRouteID;
            }
        }

        [Route("getpercent")]
        [HttpGet]
        public async Task<List<List<Percent>>> GetPercentAsync([FromServices] InitSapDbWorker initSapDbWorker, DateTime fromDate, DateTime toDate)
        {
            List<List<Percent>> percents = new List<List<Percent>>();
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            try
            {
                if (sapDBWorker.Connected())
                {
                    percents = await Task.Run(new Func<List<List<Percent>>>(() => sapDBWorker.GetPercentAgent(fromDate,toDate)));
                };

                return percents;
            }
            catch (Exception ex)
            {
                return percents;
            }
        }

        [Route("getpercentdetailssupervisor")]
        [HttpGet]
        public async Task<List<PercentDeliveryAgent>> GetPercentDetailsSupervisorAsync([FromServices] InitSapDbWorker initSapDbWorker, DateTime fromDate, DateTime toDate, string code)
        {
            List<PercentDeliveryAgent> percents = new List<PercentDeliveryAgent>();
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            try
            {
                if (sapDBWorker.Connected())
                {
                    percents = await Task.Run(new Func<List<PercentDeliveryAgent>>(() => sapDBWorker.GetPerecentDetailsSupervisor(fromDate, toDate, code.Replace("_", " ").Replace("-", "#"))));
                };

                return percents;
            }
            catch (Exception ex)
            {
                return percents;
            }
        }
        [Route("getpercentdetailsdeliver")]
        [HttpGet]
        public async Task<List<PercentDeliveryAgent>> GetPercentDetailsDeliveriAgentAsync([FromServices] InitSapDbWorker initSapDbWorker, DateTime fromDate, DateTime toDate, string code)
        {
            List<PercentDeliveryAgent> percents = new List<PercentDeliveryAgent>();
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            try
            {
                if (sapDBWorker.Connected())
                {
                    percents = await Task.Run(new Func<List<PercentDeliveryAgent>>(() => sapDBWorker.GetPerecentDetailsDeliveryAgent(fromDate, toDate, code)));
                };

                return percents;
            }
            catch (Exception ex)
            {
                return percents;
            }
        }
        [Route("getpercentdetailsagent")]
        [HttpGet]
        public async Task<List<PercentDeliveryAgent>> GetPercentDetailsAgentAsync([FromServices] InitSapDbWorker initSapDbWorker, DateTime fromDate, DateTime toDate, string code)
        {
            List<PercentDeliveryAgent> percents = new List<PercentDeliveryAgent>();
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            try
            {
                if (sapDBWorker.Connected())
                {
                    percents = await Task.Run(new Func<List<PercentDeliveryAgent>>(() => sapDBWorker.GetPerecentDetailsAgent(fromDate, toDate, code)));
                };

                return percents;
            }
            catch (Exception ex)
            {
                return percents;
            }
        }

        [Route("getconsignment")]
        [HttpGet]
        public async Task<List<Сonsignment>> GetСonsignmentAsync([FromServices] InitSapDbWorker initSapDbWorker, DateTime fromDate, DateTime toDate, string code)
        {
            List<Сonsignment> percents = new List<Сonsignment>();
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            try
            {
                if (sapDBWorker.Connected())
                {
                    percents = await Task.Run(new Func<List<Сonsignment>>(() => sapDBWorker.GetСonsignment(fromDate, toDate, code)));
                };

                return percents;
            }
            catch (Exception ex)
            {
                return percents;
            }
        }


        [Route("prepaymentrepor")]
        [HttpGet]
        public async Task<List<PrepaymentReport>> GetPrepaymentReportAsync([FromServices] InitSapDbWorker initSapDbWorker, DateTime fromDate, DateTime toDate)
        {
            List<PrepaymentReport> percents = new List<PrepaymentReport>();
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            try
            {
                if (sapDBWorker.Connected())
                {
                    percents = await Task.Run(new Func<List<PrepaymentReport>>(() => sapDBWorker.GetPrepaymentReport(fromDate, toDate)));
                };

                return percents;
            }
            catch (Exception ex)
            {
                return percents;
            }
        }


        [Route("consigmentclient")]
        [HttpGet]
        public async Task<List<ConsigmentClient>> GetConsigmentClientAsync([FromServices] InitSapDbWorker initSapDbWorker)
        {
            List<ConsigmentClient> percents = new List<ConsigmentClient>();
            SapDBWorker sapDBWorker = initSapDbWorker.GetSapDBWorker();

            try
            {
                if (sapDBWorker.Connected())
                {
                    percents = await Task.Run(new Func<List<ConsigmentClient>>(() => sapDBWorker.GetConsigmentClient()));
                };

                return percents;
            }
            catch (Exception ex)
            {
                return percents;
            }
        }
    }
}
