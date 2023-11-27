using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class YardAppointmentsDoorTimeSlot
{
    public string Door { get; set; } = null!;

    public DateTime? ScheduleDate { get; set; }

    public string? TimeSlot { get; set; }

    public string? TimeSlotDisplay { get; set; }

    public int? DurationTillNextAppointment { get; set; }

    public bool? DoorOccupiedAtTimeSlot { get; set; }

    public string AppointmentId { get; set; } = null!;
}
