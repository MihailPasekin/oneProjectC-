using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Replpolicyscoring
{
    public string Policyid { get; set; } = null!;

    public decimal? Accessibility { get; set; }

    public decimal? Receivedate { get; set; }

    public decimal? Units { get; set; }

    public decimal? Expirydate { get; set; }

    public decimal? Weight { get; set; }

    public decimal? Serial { get; set; }

    public decimal? Kosher { get; set; }

    public decimal? Harvest { get; set; }

    public decimal? Color { get; set; }

    public decimal? Size { get; set; }

    public decimal? Batch { get; set; }

    public decimal? Mfgdate { get; set; }
}
