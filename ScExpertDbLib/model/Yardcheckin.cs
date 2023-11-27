using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Yardcheckin
{
    public string Checkinid { get; set; } = null!;

    public DateTime Checkindate { get; set; }

    public string Vehicle { get; set; } = null!;

    public string? Trailer { get; set; }

    public string? Seal1 { get; set; }

    public string? Seal2 { get; set; }

    public string Yardlocation { get; set; } = null!;

    public string Driver1 { get; set; } = null!;

    public string? Driver2 { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
