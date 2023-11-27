using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Shiftdetail
{
    public string Shiftcode { get; set; } = null!;

    public int Shiftday { get; set; }

    public int? Shiftstarttime { get; set; }

    public int? Shiftendtime { get; set; }
}
