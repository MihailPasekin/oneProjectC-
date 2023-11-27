using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VRouteGeneralTask
{
    public string? Routeid { get; set; }

    public int? Stopnumber { get; set; }

    public int? Stoptaskid { get; set; }

    public string Taskid { get; set; } = null!;

    public string Tasktype { get; set; } = null!;

    public DateTime Scheduledate { get; set; }

    public string Status { get; set; } = null!;

    public DateTime Statusdate { get; set; }

    public string? Notes { get; set; }

    public string Consignee { get; set; } = null!;

    public string Company { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public string Contactid { get; set; } = null!;
}
