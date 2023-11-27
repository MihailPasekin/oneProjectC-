using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Consigneeputaway
{
    public int Putawayid { get; set; }

    public string Consignee { get; set; } = null!;

    public string? Classname { get; set; }

    public string? Status { get; set; }

    public string? Sku { get; set; }

    public string? Velocity { get; set; }

    public string? Skugroup { get; set; }

    public string Putawaypolicy { get; set; } = null!;

    public string? Transporttype { get; set; }

    public DateTime? Expirydate { get; set; }

    public decimal? Weight { get; set; }

    public string? Serial { get; set; }

    public bool? Kosher { get; set; }

    public int? Harvest { get; set; }

    public string? Color { get; set; }

    public string? Size { get; set; }

    public string? Batch { get; set; }

    public DateTime? Mfgdate { get; set; }

    public int? Priority { get; set; }

    public string? Hazclass { get; set; }

    public string? Hutype { get; set; }

    public string? Transportationclass { get; set; }

    public string? Storageclass { get; set; }

    public string? Policyid { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
