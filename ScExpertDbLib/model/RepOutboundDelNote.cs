using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class RepOutboundDelNote
{
    public string Consignee { get; set; } = null!;

    public string Orderid { get; set; } = null!;

    public string Ordertype { get; set; } = null!;

    public string? Referenceord { get; set; }

    public string Targetcompany { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public string? Status { get; set; }

    public DateTime Createdate { get; set; }

    public string? Notes { get; set; }

    public string? Staginglane { get; set; }

    public DateTime? Requesteddate { get; set; }

    public DateTime? Scheduleddate { get; set; }

    public DateTime? Shippeddate { get; set; }

    public string? Shipment { get; set; }

    public int? Stopnumber { get; set; }

    public string? Wave { get; set; }

    public DateTime? Statusdate { get; set; }

    public string? Loadingseq { get; set; }

    public string? Routingset { get; set; }

    public string? Route { get; set; }

    public string? Deliverystatus { get; set; }

    public string? Pod { get; set; }

    public int? Orderpriority { get; set; }

    public string? Hostorderid { get; set; }

    public string? Shipto { get; set; }

    public DateTime? Expecteddate { get; set; }

    public int Orderline { get; set; }

    public string? Referenceordline { get; set; }

    public string? Sku { get; set; }

    public string Inventorystatus { get; set; } = null!;

    public decimal? Qtyoriginal { get; set; }

    public decimal? Qtymodified { get; set; }

    public decimal? Qtyallocated { get; set; }

    public decimal? Qtypicked { get; set; }

    public decimal? Qtystaged { get; set; }

    public decimal? Qtyloaded { get; set; }

    public decimal? Qtyshipped { get; set; }

    public long? Exploadedflag { get; set; }

    public string? Lineoum { get; set; }

    public decimal? Uomqty { get; set; }

    public string? Companyname { get; set; }

    public string? Consigneename { get; set; }

    public string? Skudesc { get; set; }

    public string? Street1 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? Contact1name { get; set; }

    public string? Contact1phone { get; set; }

    public string? Defaultcontact { get; set; }
}
