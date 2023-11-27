using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class TalkmanTaskAssignment
{
    public string Task { get; set; } = null!;

    public string Tasktype { get; set; } = null!;

    public string? Location { get; set; }

    public string? Checkdigits { get; set; }

    public string? Warehousearea { get; set; }
}
