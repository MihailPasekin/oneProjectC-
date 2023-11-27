using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class LblLoadShip
{
    public string Loadid { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string Loaduom { get; set; } = null!;

    public string Location { get; set; } = null!;

    public decimal Units { get; set; }

    public string Orderid { get; set; } = null!;

    public string Ordertype { get; set; } = null!;

    public string? Referenceord { get; set; }

    public string Picklist { get; set; } = null!;

    public string Targetcompany { get; set; } = null!;

    public string Companytype { get; set; } = null!;

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

    public string? Skudesc { get; set; }

    public string? Skushortdesc { get; set; }

    public string? Manufacturersku { get; set; }

    public string? Vendorsku { get; set; }

    public string? Othersku { get; set; }

    public string? Skugroup { get; set; }

    public string? Classname { get; set; }

    public string? Comptypedesc { get; set; }

    public string? Outordtypedesc { get; set; }

    public string? Door { get; set; }

    public string? Carrier { get; set; }

    public string? Trailer { get; set; }

    public string? Carriername { get; set; }

    public string? Companyname { get; set; }

    public string? Othercompany { get; set; }

    public string? Companygroup { get; set; }

    public string? Street1 { get; set; }

    public string? Street2 { get; set; }

    public string? City { get; set; }

    public string? Zip { get; set; }

    public string? State { get; set; }

    public string? Contact1name { get; set; }

    public string? Contact2name { get; set; }

    public string? Contact1phone { get; set; }

    public string? Contact2phone { get; set; }

    public string? Contact1fax { get; set; }

    public string? Contact2fax { get; set; }

    public string? Contact1email { get; set; }

    public string? Contact2email { get; set; }

    public string? Uomdesc { get; set; }

    public int Uomunits { get; set; }
}
