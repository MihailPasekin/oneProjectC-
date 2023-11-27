using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Taskassignpolicydetail
{
    public int Policyline { get; set; }

    public string Policyid { get; set; } = null!;

    public int Priority { get; set; }

    public string? Tasktype { get; set; }

    public string? Tasksubtype { get; set; }

    public string? Stayinaisle { get; set; }

    public string? Interleaving { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
