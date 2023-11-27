using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Planstrategyheader
{
    public string Strategyid { get; set; } = null!;

    public string? Description { get; set; }

    public string Pickmethod { get; set; } = null!;

    public bool? Pcksforfullaloc { get; set; }

    public bool Createloadingplan { get; set; }

    public decimal? Picklistbasecube { get; set; }

    public decimal? Picklistbaseweight { get; set; }

    public string? Substituteskumode { get; set; }

    public bool? Pickpartialuom { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
