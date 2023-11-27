using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Billingagreementheader
{
    public string Name { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string? Description { get; set; }

    public string Status { get; set; } = null!;

    public double Minvalue { get; set; }

    public double? Maxvalue { get; set; }

    public string Periodtype { get; set; } = null!;

    public string Period { get; set; } = null!;

    public string? Priceequation { get; set; }

    public DateTime? Enddate { get; set; }

    public DateTime Startdate { get; set; }

    public DateTime Lastrundate { get; set; }

    public DateTime Nextrundate { get; set; }

    public bool? Active { get; set; }

    public string? Performadoc { get; set; }

    public bool? Autopostcharges { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
