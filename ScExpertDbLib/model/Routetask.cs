using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Routetask
{
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

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
