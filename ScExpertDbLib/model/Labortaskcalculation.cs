using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Labortaskcalculation
{
    public string Tasktype { get; set; } = null!;

    public string Laborcalcid { get; set; } = null!;

    public int? Generictime { get; set; }

    public string? Newassigment { get; set; }

    public string? Defaultmhetype { get; set; }

    public string? Tasksubtype { get; set; }

    public int? Indirectflag { get; set; }
}
