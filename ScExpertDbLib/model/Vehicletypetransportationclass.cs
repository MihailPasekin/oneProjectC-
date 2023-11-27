using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Vehicletypetransportationclass
{
    public string Vehicletypename { get; set; } = null!;

    public string Transportationclass { get; set; } = null!;

    public double? Maxcube { get; set; }

    public double? Maxweight { get; set; }

    public double? Mincube { get; set; }

    public double? Minweight { get; set; }

    public string? Adduser { get; set; }

    public DateTime Adddate { get; set; }

    public string? Edituser { get; set; }

    public DateTime Editdate { get; set; }
}
