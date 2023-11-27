using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Shipmentrequirement
{
    public string Consignee { get; set; } = null!;

    public string Orderid { get; set; } = null!;

    public string Ordertype { get; set; } = null!;

    public string Targetcompany { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public string? Shipment { get; set; }

    public string? Route { get; set; }

    public int Orderline { get; set; }

    public string? Sku { get; set; }

    public decimal? Qtymodified { get; set; }

    public decimal? RemainQty { get; set; }
}
