using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VSchedulerYardAppointment
{
    public string Scheduleid { get; set; } = null!;

    public string Appointmentid { get; set; } = null!;

    public string? Status { get; set; }

    public DateTime? Statusdate { get; set; }

    public string? Carrier { get; set; }

    public string Door { get; set; } = null!;

    public string YardLocation { get; set; } = null!;

    public DateTime Fromdate { get; set; }

    public DateTime Todate { get; set; }

    public string? Subject { get; set; }

    public string Reqid { get; set; } = null!;
}
