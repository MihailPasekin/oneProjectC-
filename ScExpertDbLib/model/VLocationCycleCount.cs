using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VLocationCycleCount
{
    public long? RowNum { get; set; }

    public string Location { get; set; } = null!;

    public bool Status { get; set; }

    public string? Putregion { get; set; }

    public string? Pickregion { get; set; }

    public string? Warehousearea { get; set; }

    public DateTime Lastcountdate { get; set; }

    public int? Cyclesdayint { get; set; }

    public decimal NumLocationPerRun { get; set; }
}
