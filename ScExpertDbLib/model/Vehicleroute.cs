using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Vehicleroute
{
    public int Vehiclerouteid { get; set; }

    public DateTime Routestart { get; set; }

    public DateTime Routeend { get; set; }

    public string Vehicleid { get; set; } = null!;

    public string? Comment { get; set; }

    public bool Predefined { get; set; }

    public bool Monday { get; set; }

    public bool Tuesday { get; set; }

    public bool Wednesday { get; set; }

    public bool Thursday { get; set; }

    public bool Friday { get; set; }

    public bool Saturday { get; set; }

    public bool Sunday { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
