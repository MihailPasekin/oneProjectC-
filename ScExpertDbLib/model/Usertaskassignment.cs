using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Usertaskassignment
{
    public int Taskid { get; set; }

    public string Policyid { get; set; } = null!;

    public int? Priority { get; set; }

    public string? Role { get; set; }

    public string? Skill { get; set; }

    public string? Mobility { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
