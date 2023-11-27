using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VDisassmbleWorkOrderBom
{
    public string Consignee { get; set; } = null!;

    public string Orderid { get; set; } = null!;

    public string Partsku { get; set; } = null!;

    public string? Skudesc { get; set; }

    public decimal Partqty { get; set; }

    public string Status { get; set; } = null!;

    public string Loaduom { get; set; } = null!;

    public string Expirydate { get; set; } = null!;

    public string Weight { get; set; } = null!;

    public string Serial { get; set; } = null!;

    public string Kosher { get; set; } = null!;

    public string Harvest { get; set; } = null!;

    public string Color { get; set; } = null!;

    public string Size { get; set; } = null!;

    public string Batch { get; set; } = null!;

    public string Mfgdate { get; set; } = null!;
}
