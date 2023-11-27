using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Handelingunittype
{
    public string Container { get; set; } = null!;

    public string Containerdesc { get; set; } = null!;

    public double? Containercube { get; set; }

    public double? Containerweight { get; set; }

    public double? Cubecapacity { get; set; }

    public double? Weightcapacity { get; set; }

    public double? Height { get; set; }

    public string? Heightcalc { get; set; }

    public double? Width { get; set; }

    public double? Length { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
