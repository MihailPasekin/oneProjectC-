using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VShiftCurrentPerformance
{
    public string Shiftid { get; set; } = null!;

    public string Shiftcode { get; set; } = null!;

    public DateTime? Startdate { get; set; }

    public string? Shortstartdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string? Shortenddate { get; set; }

    public int StdTime { get; set; }

    public decimal TaskDelaysTime { get; set; }

    public int AccountableTime { get; set; }

    public int? TotalShifttime { get; set; }

    public int NonAccountableTime { get; set; }

    public decimal? ShiftPerformance { get; set; }
}
