using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Vehiclecontainer
{
    public string Shipment { get; set; } = null!;

    public string? Status { get; set; }

    public DateTime? Createdate { get; set; }

    public DateTime? Shippeddate { get; set; }

    public string? Door { get; set; }

    public string? Carrier { get; set; }

    public string? Trailer { get; set; }

    public string? Driver { get; set; }

    public string Consignee { get; set; } = null!;

    public string Orderid { get; set; } = null!;

    public int Orderline { get; set; }

    public string? Wave { get; set; }

    public string? Route { get; set; }

    public decimal? Pickedqty { get; set; }

    public string? Uom { get; set; }

    public string Ordertype { get; set; } = null!;

    public string Targetcompany { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public string? Sku { get; set; }

    public string? Skudesc { get; set; }

    public decimal? Qtyoriginal { get; set; }

    public decimal? Qtymodified { get; set; }

    public decimal? Qtypicked { get; set; }

    public decimal? Qtystaged { get; set; }

    public decimal? Qtyloaded { get; set; }

    public decimal? Qtyshipped { get; set; }

    public string? Containerid { get; set; }

    public string? Lowestuom { get; set; }

    public decimal? Uomqty { get; set; }
}
