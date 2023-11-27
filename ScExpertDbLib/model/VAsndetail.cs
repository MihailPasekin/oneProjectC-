using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VAsndetail
{
    public string Asnid { get; set; } = null!;

    public string Receipt { get; set; } = null!;

    public int Receiptline { get; set; }

    public string Container { get; set; } = null!;

    public string? Loadid { get; set; }

    public string Uom { get; set; } = null!;

    public string Status { get; set; } = null!;

    public decimal? Units { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }

    public string Sku { get; set; } = null!;

    public string? Skudesc { get; set; }

    public string? Skushortdesc { get; set; }

    public string? Manufacturersku { get; set; }

    public string? Vendorsku { get; set; }

    public string? Othersku { get; set; }

    public string? Skugroup { get; set; }

    public string? Classname { get; set; }

    public string Consignee { get; set; } = null!;
}
