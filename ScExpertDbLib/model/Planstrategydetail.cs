using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Planstrategydetail
{
    public int Strategyline { get; set; }

    public string Strategyid { get; set; } = null!;

    public int Priority { get; set; }

    public string? Pickregion { get; set; }

    public string? Uom { get; set; }

    public string Picktype { get; set; } = null!;

    public bool Allocfullrequirement { get; set; }

    public bool Allocbylineuom { get; set; }

    public string? Locpicktype { get; set; }

    public decimal? Npppwvol { get; set; }

    public bool? Allocbyhighestuom { get; set; }

    public string? Allocuomqty { get; set; }

    public bool? Overallocpicklocs { get; set; }

    public bool Zpicking { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
