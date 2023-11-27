using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VMobileRepl2
{
    public string Task { get; set; } = null!;

    public string Note { get; set; } = null!;

    public string Tasktype { get; set; } = null!;

    public string? Loadid { get; set; }

    public string? Consignee { get; set; }

    public string? Sku { get; set; }

    public string Skudesc { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string Uomunits { get; set; } = null!;

    public string Units { get; set; } = null!;

    public string Spacer { get; set; } = null!;

    public string Tolocation { get; set; } = null!;
}
