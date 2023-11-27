using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VShiftTaskPerformance
{
    public string? Userid { get; set; }

    public int IdleStarttime { get; set; }

    public int? IdleEndTime { get; set; }

    public string? ShiftId { get; set; }

    public string ShiftCode { get; set; } = null!;

    public DateTime? Startdate { get; set; }

    public DateTime? Enddate { get; set; }

    public string? Tasktype { get; set; }

    public string? TaskId { get; set; }

    public int Indirectflag { get; set; }

    public int StdTime { get; set; }

    public decimal TaskDelaysTime { get; set; }

    public int TaskActualTime { get; set; }

    public int IdleTime { get; set; }

    public int TaskAccountableBreak { get; set; }

    public int TaskNonAccountableBreak { get; set; }

    public decimal? ShiftPerformance { get; set; }
}
