using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VYardAppointmentsRequirement
{
    public string ReqType { get; set; } = null!;

    public string Reqid { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string? Bol { get; set; }

    public string? Comments { get; set; }

    public DateTime? Scheduledate { get; set; }

    public string Appointmentid { get; set; } = null!;

    public string? DisplayText { get; set; }
}
