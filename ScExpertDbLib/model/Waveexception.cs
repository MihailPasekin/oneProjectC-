using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Waveexception
{
    public string Wave { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string Company { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public string? Companyname { get; set; }

    public string Orderid { get; set; } = null!;

    public string Ordertype { get; set; } = null!;

    public string? Ordertypedesc { get; set; }

    public string? Route { get; set; }

    public string? Shipment { get; set; }

    public int Orderline { get; set; }

    public string? Sku { get; set; }

    public string? Skudesc { get; set; }

    public decimal? Qtymodified { get; set; }

    public decimal? ExceptionQty { get; set; }

    public decimal Availableqty { get; set; }

    public decimal AllocatedQty { get; set; }
}
