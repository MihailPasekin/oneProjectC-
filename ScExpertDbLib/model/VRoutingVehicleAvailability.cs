using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VRoutingVehicleAvailability
{
    public DateTime? Date { get; set; }

    public string? Strategyid { get; set; }

    public string? Vehicletype { get; set; }

    public int Priority { get; set; }

    public int? TotalVehiclesOfType { get; set; }

    public int? MultiDayRoute { get; set; }

    public DateTime? Startdate { get; set; }

    public DateTime? AvailableFromTime { get; set; }

    public int? Numvehicles { get; set; }
}
