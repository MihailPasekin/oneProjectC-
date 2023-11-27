using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class RepInvAdj
{
    public string? Userid { get; set; }

    public string? Fullname { get; set; }

    public string? Activitydate { get; set; }

    public DateTime? Activitydate2 { get; set; }

    public string? Activitytype { get; set; }

    public string? Manufacturersku { get; set; }

    public string? Skudesc { get; set; }

    public decimal? Fromqty { get; set; }

    public decimal? Toqty { get; set; }

    public string? Notes { get; set; }

    public string Location { get; set; } = null!;
}
