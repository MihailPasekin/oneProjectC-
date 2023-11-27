using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VMobileCnt2
{
    public string Loadid { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string? SkuDesc { get; set; }

    public string Location { get; set; } = null!;

    public string Spacer { get; set; } = null!;

    public string? Uom { get; set; }

    public string Tounits { get; set; } = null!;

    public string Tolocation { get; set; } = null!;
}
