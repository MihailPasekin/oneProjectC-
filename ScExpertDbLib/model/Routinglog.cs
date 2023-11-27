using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Routinglog
{
    public int Id { get; set; }

    public string Runid { get; set; } = null!;

    public int Generation { get; set; }

    public string Chrom { get; set; } = null!;

    public double Score { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
