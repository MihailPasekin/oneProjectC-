using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VMobileRpk2
{
    public string Task { get; set; } = null!;

    public string Note { get; set; } = null!;

    public string Loadid { get; set; } = null!;

    public string? Consignee { get; set; }

    public string? Sku { get; set; }

    public string Skudesc { get; set; } = null!;

    public string Uom { get; set; } = null!;

    public string Units { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string Spacer { get; set; } = null!;

    public string Handlingunit { get; set; } = null!;

    public string? Handlingunittype { get; set; }

    public string Confirm { get; set; } = null!;
}
