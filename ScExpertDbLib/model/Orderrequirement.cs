using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Orderrequirement
{
    public string? Wave { get; set; }

    public string Consignee { get; set; } = null!;

    public string Targetcompany { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public string? Companygroup { get; set; }

    public string Orderid { get; set; } = null!;

    public string Ordertype { get; set; } = null!;

    public string? Shipment { get; set; }

    public string? Staginglane { get; set; }

    public string? Route { get; set; }

    public int Orderpriority { get; set; }

    public double? Ordervalue { get; set; }

    public double Ordervolume { get; set; }

    public double? Orderweight { get; set; }

    public int Orderline { get; set; }

    public string? Sku { get; set; }

    public decimal? Qtylefttofullfill { get; set; }

    public string Velocity { get; set; } = null!;

    public string Skugroup { get; set; } = null!;

    public string Classname { get; set; } = null!;

    public string Hazclass { get; set; } = null!;

    public string Picksortorder { get; set; } = null!;

    public string Invstatus { get; set; } = null!;

    public string? Pkeytype { get; set; }

    public string? Pkey1 { get; set; }

    public string? Pkey2 { get; set; }

    public string? Pkey3 { get; set; }

    public DateTime? Expirydate { get; set; }

    public decimal? Weight { get; set; }

    public string? Serial { get; set; }

    public bool? Kosher { get; set; }

    public int? Harvest { get; set; }

    public string? Color { get; set; }

    public string? Size { get; set; }

    public string? Batch { get; set; }

    public DateTime? Mfgdate { get; set; }

    public double Linevolume { get; set; }

    public double? Linevalue { get; set; }

    public decimal Lineunits { get; set; }

    public int? Orderlines { get; set; }

    public decimal? Orderunits { get; set; }

    public string Carrier { get; set; } = null!;

    public string Unloadingtype { get; set; } = null!;

    public string Vehicletype { get; set; } = null!;

    public string Transporttype { get; set; } = null!;

    public double? Leftqtyvolume { get; set; }

    public string? Shipto { get; set; }
}
