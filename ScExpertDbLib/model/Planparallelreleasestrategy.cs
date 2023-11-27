using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Planparallelreleasestrategy
{
    public int Parallelstratid { get; set; }

    public string Strategyid { get; set; } = null!;

    public int Priority { get; set; }

    public string? Handelingunittype { get; set; }

    public bool? Route { get; set; }

    public bool? Staginglane { get; set; }

    public bool? Customer { get; set; }

    public bool? Shipment { get; set; }

    public string? Onhutype { get; set; }

    public int? Numlists { get; set; }

    public bool? Pickregion { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
