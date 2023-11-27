using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Mhe
{
    public string Mheid { get; set; } = null!;

    public string Mhetype { get; set; } = null!;

    public double? Walkconst { get; set; }

    public double? Walkvar { get; set; }

    public double? Slowconst { get; set; }

    public double? Slowvar { get; set; }

    public double? Fastconst { get; set; }

    public double? Fastvar { get; set; }

    public double? Upconst { get; set; }

    public double? Upvar { get; set; }

    public double? Downconst { get; set; }

    public double? Downvar { get; set; }

    public double? Insertconst { get; set; }

    public double? Horizontalweightconst { get; set; }

    public double? Horizontalweightvar { get; set; }

    public double? Verticalweightconst { get; set; }

    public double? Verticalweightvar { get; set; }

    public string? Labelprinter { get; set; }

    public string? Terminaltype { get; set; }

    public decimal? Maxreachheight { get; set; }

    public double? Walkthreshold { get; set; }

    public double? Slowthreshold { get; set; }

    public double? Fastthreshold { get; set; }

    public double? Horizontalconst { get; set; }

    public double? Horizontalvar { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
