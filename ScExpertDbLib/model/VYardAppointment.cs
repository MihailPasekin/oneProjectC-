using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VYardAppointment
{
    public string Appointmentid { get; set; } = null!;

    public string? Status { get; set; }

    public DateTime? Statusdate { get; set; }

    public string? Carrier { get; set; }

    public string? Vehicle { get; set; }

    public string? Trailer { get; set; }

    public string? Door { get; set; }

    public DateTime? Scheduledate { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;

    public string? Seal1 { get; set; }

    public string? Seal2 { get; set; }

    public DateTime? Checkindate { get; set; }

    public string? Notes { get; set; }

    public string? Delayreasoncode { get; set; }

    public string? Scheduleid { get; set; }

    public DateTime? Fromdate { get; set; }

    public DateTime? Todate { get; set; }

    public DateTime? Actualstartdate { get; set; }

    public DateTime? Actualenddate { get; set; }

    public string? ScheduleStatus { get; set; }

    public string? ScheduleDoor { get; set; }

    public string? Equipmentid { get; set; }

    public string? Yardlocation { get; set; }

    public string? EquipmentStatus { get; set; }

    public string? Tagnumber { get; set; }

    public int? ScheduledDuration { get; set; }

    public string? Driver1 { get; set; }

    public string? Driver2 { get; set; }

    public DateTime? EstEndDate { get; set; }

    public int? Duration { get; set; }
}
