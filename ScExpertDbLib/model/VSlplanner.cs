using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VSlplanner
{
    public string Location { get; set; } = null!;

    public bool Status { get; set; }

    public double Cubic { get; set; }

    public double NewOrdersMeasure { get; set; }

    public double PlannedOrdersMeasure { get; set; }

    public double PickingOrdersMeasure { get; set; }

    public double PickedOrdersMeasure { get; set; }

    public double StagedOrdersMeasure { get; set; }

    public double WaveAssignedOrdersMeasure { get; set; }

    public double ShipmentAssignedOrdersMeasure { get; set; }

    public double PackedOrdersMeasure { get; set; }
}
