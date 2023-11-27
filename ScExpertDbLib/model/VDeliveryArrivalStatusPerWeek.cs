using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VDeliveryArrivalStatusPerWeek
{
    public string Routeid { get; set; } = null!;

    public int? Stopnumber { get; set; }

    public DateTime? Arrivalday { get; set; }

    public DateTime? Arrivaldate { get; set; }

    public DateTime? Actualarrivaldate { get; set; }

    public string Arrivalstatus { get; set; } = null!;
}
