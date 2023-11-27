using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Routebreak
{
    public string Routeid { get; set; } = null!;

    public int Breaknumber { get; set; }

    public string Breaktype { get; set; } = null!;

    public DateTime Planstarttime { get; set; }

    public DateTime Planendtime { get; set; }

    public DateTime? Actualstarttime { get; set; }

    public DateTime? Actualendtime { get; set; }

    public string? Breakcomments { get; set; }

    public double? Lat { get; set; }

    public double? Lon { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
