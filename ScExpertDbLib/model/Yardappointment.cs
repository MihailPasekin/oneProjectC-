using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Yardappointment
{
    public string Appointmentid { get; set; } = null!;

    public string? Status { get; set; }

    public DateTime? Statusdate { get; set; }

    public string? Carrier { get; set; }

    public string? Vehicle { get; set; }

    public string? Trailer { get; set; }

    public string? Seal1 { get; set; }

    public string? Seal2 { get; set; }

    public string? Driver1 { get; set; }

    public string? Driver2 { get; set; }

    public string? Door { get; set; }

    public DateTime? Scheduledate { get; set; }

    public DateTime? Checkindate { get; set; }

    public string? Delayreasoncode { get; set; }

    public string? Notes { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
