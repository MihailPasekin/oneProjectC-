using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class LblPick
{
    public string Picklist { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string Orderid { get; set; } = null!;

    public string Ordertype { get; set; } = null!;

    public string? Referenceord { get; set; }

    public string Targetcompany { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public DateTime Createdate { get; set; }

    public string? Notes { get; set; }

    public string? Staginglane { get; set; }

    public DateTime? Requesteddate { get; set; }

    public DateTime? Scheduleddate { get; set; }

    public DateTime? Shippeddate { get; set; }

    public string? Shipment { get; set; }

    public int? Stopnumber { get; set; }

    public string? Wave { get; set; }

    public string? Loadingseq { get; set; }

    public string? Routingset { get; set; }

    public string? Route { get; set; }

    public string? Deliverystatus { get; set; }

    public int? Orderpriority { get; set; }

    public int Orderline { get; set; }

    public string? Referenceordline { get; set; }

    public string Inventorystatus { get; set; } = null!;

    public decimal? Qtyoriginal { get; set; }

    public decimal? Qtymodified { get; set; }

    public string? Companyname { get; set; }

    public string? Othercompany { get; set; }

    public string? Companygroup { get; set; }

    public string? Street1 { get; set; }

    public string? Street2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? Contact1name { get; set; }

    public string? Contact2name { get; set; }

    public string? Contact1phone { get; set; }

    public string? Contact2phone { get; set; }

    public string? Contact1fax { get; set; }

    public string? Contact2fax { get; set; }

    public string? Contact1email { get; set; }

    public string? Contact2email { get; set; }

    public string Sku { get; set; } = null!;

    public string? Skudesc { get; set; }

    public string? Skushortdesc { get; set; }

    public string? Manufacturersku { get; set; }

    public string? Vendorsku { get; set; }

    public string? Othersku { get; set; }

    public string? Skugroup { get; set; }

    public string? Classname { get; set; }

    public string Velocity { get; set; } = null!;

    public double? Unitprice { get; set; }

    public string? Picksortorder { get; set; }

    public string? Uom { get; set; }

    public decimal Qty { get; set; }

    public decimal Adjqty { get; set; }

    public string? Uomdesc { get; set; }

    public string? Comptypedesc { get; set; }

    public string? Outordtypedesc { get; set; }

    public int Uomunits { get; set; }
}
