using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VMobileLoadInq1
{
    public string Loadid { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string? Skudesc { get; set; }

    public string? Uom { get; set; }

    public string Location { get; set; } = null!;

    public string Spacer { get; set; } = null!;
}
