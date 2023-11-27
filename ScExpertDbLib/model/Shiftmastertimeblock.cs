using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Shiftmastertimeblock
{
    public string Shiftcode { get; set; } = null!;

    public int Shiftday { get; set; }

    public string? Timeblocktype { get; set; }

    public int Fromtime { get; set; }

    public int Totime { get; set; }

    public bool? Accountabletime { get; set; }
}
