using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VCountBookTask
{
    public string Task { get; set; } = null!;

    public string Tasktype { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Fromlocation { get; set; }

    public string? Fromload { get; set; }

    public string? Consignee { get; set; }

    public string? Sku { get; set; }

    public int Priority { get; set; }

    public bool Assigned { get; set; }

    public string? Userid { get; set; }

    public DateTime? Starttime { get; set; }

    public DateTime? Endtime { get; set; }

    public DateTime? Assignedtime { get; set; }

    public int? Executiontime { get; set; }

    public string? Countid { get; set; }

    public string? Countbook { get; set; }

    public string? Countbookrunid { get; set; }
}
