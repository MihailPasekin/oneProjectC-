using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Vehiclelocation
{
    public string Vehicletype { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string Side { get; set; } = null!;

    public int? Bay { get; set; }

    public string? Level { get; set; }

    public double? Width { get; set; }

    public double? Height { get; set; }

    public double? Depth { get; set; }

    public double? Weightlimit { get; set; }

    public string? Status { get; set; }

    public string? Adduser { get; set; }

    public DateTime Adddate { get; set; }

    public string? Edituser { get; set; }

    public DateTime Editdate { get; set; }
}
