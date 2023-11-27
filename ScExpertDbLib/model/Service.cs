using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Service
{
    public string Consignee { get; set; } = null!;

    public string Company { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public DateTime Schedualeddate { get; set; }

    public string Status { get; set; } = null!;

    public string? Comments { get; set; }

    public string Trip { get; set; } = null!;

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
