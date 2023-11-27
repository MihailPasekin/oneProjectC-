using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Replenishment
{
    public string Replid { get; set; } = null!;

    public string Repltype { get; set; } = null!;

    public string Replmethod { get; set; } = null!;

    public string Fromload { get; set; } = null!;

    public string Fromlocation { get; set; } = null!;

    public string Toload { get; set; } = null!;

    public string Tolocation { get; set; } = null!;

    public decimal Units { get; set; }

    public string Uom { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
