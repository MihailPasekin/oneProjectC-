using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Routingset
{
    public string Setid { get; set; } = null!;

    public DateTime? Createdate { get; set; }

    public DateTime? Plandate { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? Distributiondate { get; set; }

    public string? Trip { get; set; }

    public int Currentindex { get; set; }

    public string? Activerunid { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
