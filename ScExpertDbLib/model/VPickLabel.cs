using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VPickLabel
{
    public string Picklist { get; set; } = null!;

    public string Picktype { get; set; } = null!;

    public string? Picktypedesc { get; set; }

    public string Pickmethod { get; set; } = null!;

    public string? Pickmethoddesc { get; set; }

    public string Strategyid { get; set; } = null!;

    public string? Strategydesc { get; set; }

    public string? Wave { get; set; }

    public string? Handelingunittype { get; set; }

    public string? Containerdesc { get; set; }

    public string? Pickregion { get; set; }

    public string Consignee { get; set; } = null!;

    public string Orderid { get; set; } = null!;

    public string Ordertype { get; set; } = null!;

    public string? Ordertypedesc { get; set; }

    public DateTime? Requesteddate { get; set; }

    public string? Staginglane { get; set; }

    public DateTime? Scheduleddate { get; set; }

    public int? Stopnumber { get; set; }

    public string? Route { get; set; }

    public string? Loadingseq { get; set; }

    public string? Shipment { get; set; }

    public DateTime? Scheddate { get; set; }

    public string? Door { get; set; }

    public string? Carrier { get; set; }

    public string? Trailer { get; set; }

    public string Company { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public string? Companytypedesc { get; set; }

    public string? Companyname { get; set; }

    public string? Othercompany { get; set; }

    public string Sku { get; set; } = null!;

    public string? Skudesc { get; set; }

    public string? Skushortdesc { get; set; }

    public string? Manufacturersku { get; set; }

    public string? Classname { get; set; }

    public string Velocity { get; set; } = null!;

    public double? Unitprice { get; set; }

    public string? Parallelpickid { get; set; }

    public int? Picklistseq { get; set; }
}
