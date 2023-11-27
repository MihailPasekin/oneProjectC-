using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VWaveHeader
{
    public string Wave { get; set; } = null!;

    public string? Wavetype { get; set; }

    public string? Status { get; set; }

    public string? Wavetypedesc { get; set; }

    public DateTime? Createdate { get; set; }

    public DateTime? Releasedate { get; set; }

    public int? Numorders { get; set; }

    public int? Numorderlines { get; set; }

    public int? Numexceptionlines { get; set; }

    public double? Totalvolume { get; set; }

    public double? Totalweight { get; set; }

    public int? Numexceptionsku { get; set; }
}
