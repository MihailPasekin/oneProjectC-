using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VShiftUsersPerformance
{
    public string? Shiftid { get; set; }

    public string? Shiftcode { get; set; }

    public string? ShiftDescription { get; set; }

    public string? Userid { get; set; }

    public int StdTime { get; set; }

    public decimal TaskDelaysTime { get; set; }

    public int AccountableTime { get; set; }

    public int TotalShifttime { get; set; }

    public int NonAccountableTime { get; set; }

    public DateTime? ShiftStartDate { get; set; }

    public DateTime? ShiftEndDate { get; set; }

    public string? Shortstartdate { get; set; }

    public string? Shortenddate { get; set; }

    public decimal IndirectTaskPerformance { get; set; }

    public decimal DirectTaskPerformance { get; set; }

    public int DirectTaskActualTime { get; set; }

    public int InDirectTaskActualTime { get; set; }

    public int DirectTaskStdTime { get; set; }

    public int InDirectTaskStdTime { get; set; }

    public int DirectTaskIdleTime { get; set; }

    public int InDirectTaskIdleTime { get; set; }

    public int TotalIdleTime { get; set; }

    public decimal? ShiftUserPerformance { get; set; }
}
