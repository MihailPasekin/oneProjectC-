using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VMobileCnttaskverfication
{
    public string Loadid { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string? Skudesc { get; set; }

    public string Uom { get; set; } = null!;

    public string CountedUnits { get; set; } = null!;

    public string Spacer { get; set; } = null!;
}
