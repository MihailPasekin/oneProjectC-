using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VCurrentUsersPerformance
{
    public string? Shiftid { get; set; }

    public string? Shiftcode { get; set; }

    public string? Userid { get; set; }

    public int StdTime { get; set; }

    public decimal TaskDelaysTime { get; set; }

    public int AccountableTime { get; set; }

    public int TotalShifttime { get; set; }

    public int NonAccountableTime { get; set; }

    public decimal IndirectTaskPerformance { get; set; }

    public decimal DirectTaskPerformance { get; set; }

    public DateTime? ShiftStartDate { get; set; }

    public DateTime? ShiftEndDate { get; set; }

    public string? Shortstartdate { get; set; }

    public string? Shortenddate { get; set; }

    public int TotalIdleTime { get; set; }

    public decimal? ShiftUserPerformance { get; set; }
}
