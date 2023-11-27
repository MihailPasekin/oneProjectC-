using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class SysUser
{
    public string Userid { get; set; } = null!;

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }
}
