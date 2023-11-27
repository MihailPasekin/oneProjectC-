using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Shifttimeblock
{
    public string Shiftid { get; set; } = null!;

    public string? Timeblocktype { get; set; }

    public int Fromtime { get; set; }

    public int Totime { get; set; }

    public bool? Accountabletime { get; set; }
}
