using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Xdockdeliveryloc
{
    public int Priority { get; set; }

    public string Consignee { get; set; } = null!;

    public string Documenttype { get; set; } = null!;

    public string Ordertype { get; set; } = null!;

    public string Sourcecompany { get; set; } = null!;

    public string? Sourcecompanytype { get; set; }

    public string Targetcompany { get; set; } = null!;

    public string? Targetcompanytype { get; set; }

    public string? Location { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
