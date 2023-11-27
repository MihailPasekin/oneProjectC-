using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VTask
{
    public string Task { get; set; } = null!;

    public string Tasktype { get; set; } = null!;

    public string? Tasktypedesc { get; set; }

    public string? Tasksubtype { get; set; }

    public string Status { get; set; } = null!;

    public string? Statusdesc { get; set; }

    public string? Picklist { get; set; }

    public string? Parallelpicklist { get; set; }

    public string? Replenishment { get; set; }

    public string? Countid { get; set; }

    public string? Consolidation { get; set; }

    public string? Consignee { get; set; }

    public string? Sku { get; set; }

    public string? Skudesc { get; set; }

    public string? Fromlocation { get; set; }

    public string? Fromload { get; set; }

    public string? Fromcontainer { get; set; }

    public string? Tolocation { get; set; }

    public string? Toload { get; set; }

    public string? Tocontainer { get; set; }

    public int Priority { get; set; }

    public bool Assigned { get; set; }

    public string? Userid { get; set; }

    public string? Document { get; set; }

    public int? Documentline { get; set; }

    public DateTime? Starttime { get; set; }

    public DateTime? Endtime { get; set; }

    public DateTime? Assignedtime { get; set; }

    public int? Executiontime { get; set; }

    public string? Startlocation { get; set; }

    public string? Assignmenttype { get; set; }

    public string? Mheid { get; set; }

    public string? Terminaltype { get; set; }

    public string? Executionlocation { get; set; }

    public decimal? Stdtime { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }

    public string? Yardmovementid { get; set; }
}
