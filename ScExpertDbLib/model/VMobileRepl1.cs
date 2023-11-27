using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VMobileRepl1
{
    public string Task { get; set; } = null!;

    public string Tasktype { get; set; } = null!;

    public string? Fromloadid { get; set; }

    public string? Consignee { get; set; }

    public string? Sku { get; set; }

    public string Skudesc { get; set; } = null!;

    public string Uom { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string Spacer { get; set; } = null!;

    public string Loadid { get; set; } = null!;

    public string Cons { get; set; } = null!;

    public string Item { get; set; } = null!;

    public string Loc { get; set; } = null!;
}
