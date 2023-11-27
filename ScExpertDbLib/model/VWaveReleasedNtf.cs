using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VWaveReleasedNtf
{
    public string Wave { get; set; } = null!;

    public string? Wavetypedesc { get; set; }

    public DateTime? Releasedate { get; set; }

    public int? Numorders { get; set; }

    public int? Numorderlines { get; set; }

    public int? Numexceptionlines { get; set; }

    public double? TotalVolume { get; set; }

    public decimal? TotalWeight { get; set; }

    public int? TotalPartialpickLists { get; set; }

    public string? TotalPartialpickLines { get; set; }

    public int? TotalFullpickpickLists { get; set; }

    public string? TotalFullpickpickLines { get; set; }

    public int? TotalNegativePicksPickLists { get; set; }

    public string? TotalNegativePickLines { get; set; }

    public int? TotalParallelPicks { get; set; }

    public string? TotalParallelPickLines { get; set; }
}
