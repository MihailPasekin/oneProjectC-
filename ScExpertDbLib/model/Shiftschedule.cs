using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Shiftschedule
{
    public int Shiftid { get; set; }

    public int? Sunstart { get; set; }

    public int? Sunend { get; set; }

    public int? Monstart { get; set; }

    public int? Monend { get; set; }

    public int? Tuestart { get; set; }

    public int? Tueend { get; set; }

    public int? Wenstart { get; set; }

    public int? Wenend { get; set; }

    public int? Thustart { get; set; }

    public int? Thuend { get; set; }

    public int? Fristart { get; set; }

    public int? Friend { get; set; }

    public int? Satstart { get; set; }

    public int? Satend { get; set; }
}
