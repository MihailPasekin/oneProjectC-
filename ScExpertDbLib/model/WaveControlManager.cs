using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class WaveControlManager
{
    public string? Wave { get; set; }

    public string Picklist { get; set; } = null!;

    public string Picktype { get; set; } = null!;

    public string Pickmethod { get; set; } = null!;

    public string Strategyid { get; set; } = null!;

    public string? Status { get; set; }

    public string? Uom { get; set; }

    public string? Route { get; set; }

    public string? Staginglane { get; set; }

    public string? Warehousearea { get; set; }

    public string? Locmhtype { get; set; }

    public decimal Pickedqty { get; set; }

    public decimal Adjqty { get; set; }

    public string? Sku { get; set; }
}
