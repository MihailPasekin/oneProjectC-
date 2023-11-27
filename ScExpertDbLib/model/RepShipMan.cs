using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class RepShipMan
{
    public string Consignee { get; set; } = null!;

    public string? Consigneename { get; set; }

    public string Orderid { get; set; } = null!;

    public string Ordertype { get; set; } = null!;

    public string? Referenceord { get; set; }

    public string Targetcompany { get; set; } = null!;

    public string? Companytype { get; set; }

    public string? Companyname { get; set; }

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

    public string? Notes { get; set; }

    public DateTime? Scheduleddate { get; set; }

    public DateTime? Shippeddate { get; set; }

    public string? Shipment { get; set; }

    public string? Wave { get; set; }

    public string? Staginglane { get; set; }

    public string Doctype { get; set; } = null!;

    public int Orderline { get; set; }

    public string? Referenceordline { get; set; }

    public string? Sku { get; set; }

    public string? Skudesc { get; set; }

    public string Inventorystatus { get; set; } = null!;

    public string? Invstatdesc { get; set; }

    public decimal? Qtyoriginal { get; set; }

    public decimal? Qtymodified { get; set; }

    public decimal? Qtyallocated { get; set; }

    public decimal? Qtypicked { get; set; }

    public decimal? Qtystaged { get; set; }

    public decimal? Qtyloaded { get; set; }

    public decimal? Qtyshipped { get; set; }
}
