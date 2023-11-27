using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VDeliveryProgressPerDay
{
    public string Routeid { get; set; } = null!;

    public int Stopnumber { get; set; }

    public string Routename { get; set; } = null!;

    public DateTime? Schedualeddate { get; set; }

    public string Status { get; set; } = null!;
}
