using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Putawaypolicyscoring
{
    public string Strategyid { get; set; } = null!;

    public decimal? Locaccessibility { get; set; }

    public decimal? Cubic { get; set; }

    public decimal? Aisle { get; set; }

    public decimal? Bay { get; set; }

    public decimal? Loclevel { get; set; }

    public decimal? Picklocdist { get; set; }
}
