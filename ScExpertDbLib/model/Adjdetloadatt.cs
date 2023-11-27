using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Adjdetloadatt
{
    public string Adjustment { get; set; } = null!;

    public int Adjustmentline { get; set; }

    public string Loadattname { get; set; } = null!;

    public string? Txtattribute { get; set; }

    public int? Intattribute { get; set; }

    public DateTime? Dateattribute { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
