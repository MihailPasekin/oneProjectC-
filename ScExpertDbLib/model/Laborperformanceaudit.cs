using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Laborperformanceaudit
{
    public string Assignmentid { get; set; } = null!;

    public string? Taskid { get; set; }

    public string? Tasktype { get; set; }

    public string? Userid { get; set; }

    public string? Terminaltype { get; set; }

    public string? Mheid { get; set; }

    public string? Shiftid { get; set; }

    public DateTime? Startdate { get; set; }

    public int? Starttime { get; set; }

    public DateTime? Enddate { get; set; }

    public int? Endtime { get; set; }

    public string? Startlocation { get; set; }

    public string? Fromlocation { get; set; }

    public string? Tolocation { get; set; }

    public int? Distancestandarttime { get; set; }

    public int? Actualtime { get; set; }

    public int? Standarttime { get; set; }

    public int? Traveldistance { get; set; }
}
