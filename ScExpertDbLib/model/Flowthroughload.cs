using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Flowthroughload
{
    public string Consignee { get; set; } = null!;

    public string Flowthrough { get; set; } = null!;

    public string Flowthroughline { get; set; } = null!;

    public string Loadid { get; set; } = null!;

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
