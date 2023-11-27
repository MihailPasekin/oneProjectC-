using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Consignee
{
    public string Consignee1 { get; set; } = null!;

    public string? Consigneename { get; set; }

    public string? Notes { get; set; }

    public double? Credit { get; set; }

    public string Contactid { get; set; } = null!;

    public string? Loadlabel { get; set; }

    public string? Skulabel { get; set; }

    public string? Loaddetaillbl { get; set; }

    public string? Shpcartonlbl { get; set; }

    public string? Shpcontainerlbl { get; set; }

    public string? Rcvmanifest { get; set; }

    public string? Packinglist { get; set; }

    public string? Shippingmanifest { get; set; }

    public string? Billingperformadoc { get; set; }

    public bool? Mixshipping { get; set; }

    public bool? Packmultipleorders { get; set; }

    public int? Cyclecounting { get; set; }

    public bool? Replanplanshort { get; set; }

    public bool? Generateloadid { get; set; }

    public bool? Autoprintloadlabelrcv { get; set; }

    public double? Creditlimit { get; set; }

    public double? Cubelimit { get; set; }

    public bool? Shippartiaload { get; set; }

    public string? Receivingloc { get; set; }

    public string? Flowthroughloadlabel { get; set; }

    public string? Billingaccount { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
