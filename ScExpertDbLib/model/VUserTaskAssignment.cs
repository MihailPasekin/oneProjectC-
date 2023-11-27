using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VUserTaskAssignment
{
    public string Userid { get; set; } = null!;

    public string? Role { get; set; }

    public string? Skill { get; set; }

    public string? Hetype { get; set; }

    public string? Mobility { get; set; }
}
