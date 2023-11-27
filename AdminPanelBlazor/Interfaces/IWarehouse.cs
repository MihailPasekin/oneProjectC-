using EComersObjectLib.Objects;

namespace AdminPanelBlazor.Interfaces
{
    public interface IWarehouse
    {
        public Task<List<LoadingReport>> GetLoadingReport(string docDate, string empID);
        public Task<List<ForwarderDocList>> GetsForwarderDocList(string docDate, string empID);
        public Task<List<WarehousesSapGet>> GetWarehousessap();
        public Task<List<SqlProductGroup>> GetProductGroup();
        public Task<List<WarehouseWithdrawal>> GetWarehouseWithdrawal(string? stock, string? idProductGroup, string? listgroupprodukt);
        public Task<List<ProductGroupsPropertiesSql>> GetProductGroupsPropertiesSql();
        public Task<List<DeliveryForReport>> GetDeliveryForReport();
        public Task<List<DeliveryForReport>> GetDeliveryForReportByRegion(string region);
    }
}
