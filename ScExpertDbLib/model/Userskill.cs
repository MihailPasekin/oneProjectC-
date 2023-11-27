using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Userskill
{
    public string Userid { get; set; } = null!;

    public string? Role { get; set; }

    public string? Skill { get; set; }
}
