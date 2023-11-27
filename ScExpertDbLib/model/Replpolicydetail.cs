using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Replpolicydetail
{
    public int Policyline { get; set; }

    public string Policyid { get; set; } = null!;

    public int Priority { get; set; }

    public string? Frompickregion { get; set; }

    public string? Uom { get; set; }

    public string? Repltype { get; set; }

    public bool? Createtask { get; set; }

    public int? Taskpriority { get; set; }

    public string? Allocuomqty { get; set; }

    public string? Conftype { get; set; }

    public string? Hotreplplanning { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
