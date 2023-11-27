using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VRouteStopTasksAssign
{
    public string Stoptasktype { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string Documentid { get; set; } = null!;

    public string Documenttype { get; set; } = null!;

    public string Company { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public DateTime? Scheduledate { get; set; }

    public string? Contactid { get; set; }

    public string? Notes { get; set; }
}
