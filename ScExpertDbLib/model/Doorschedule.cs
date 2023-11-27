using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Doorschedule
{
    public string Scheduleid { get; set; } = null!;

    public DateTime Fromdate { get; set; }

    public DateTime Todate { get; set; }

    public DateTime? Actualstartdate { get; set; }

    public DateTime? Actualenddate { get; set; }

    public string Status { get; set; } = null!;

    public string Door { get; set; } = null!;

    public string Yardappointmentid { get; set; } = null!;

    public string Yardequipmentid { get; set; } = null!;

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
