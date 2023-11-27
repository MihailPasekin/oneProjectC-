using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Vgeneraltask
{
    public string Taskid { get; set; } = null!;

    public string Tasktype { get; set; } = null!;

    public string? Tasktypedesc { get; set; }

    public DateTime Scheduledate { get; set; }

    public string Status { get; set; } = null!;

    public DateTime Statusdate { get; set; }

    public string? Notes { get; set; }

    public string Consignee { get; set; } = null!;

    public string Company { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public string Contactid { get; set; } = null!;

    public string? Companyname { get; set; }

    public string? Street1 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? Contact1name { get; set; }

    public string? Contact1phone { get; set; }

    public string? Street2 { get; set; }

    public string? Contact2phone { get; set; }
}
