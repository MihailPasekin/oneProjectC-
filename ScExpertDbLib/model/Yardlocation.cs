using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Yardlocation
{
    public string Yardlocation1 { get; set; } = null!;

    public string? Yardlocationtype { get; set; }

    public bool? Status { get; set; }

    public string? Yardarea { get; set; }

    public string? Checkdigits { get; set; }

    public int? Xcoordinate { get; set; }

    public int? Ycoordinate { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
