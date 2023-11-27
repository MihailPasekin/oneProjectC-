using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class RepPutAwayWorksheet
{
    public string Loadid { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string Loaduom { get; set; } = null!;

    public string? Destinationlocation { get; set; }

    public string Status { get; set; } = null!;

    public string Location { get; set; } = null!;

    public decimal Unitsavailable { get; set; }
}
