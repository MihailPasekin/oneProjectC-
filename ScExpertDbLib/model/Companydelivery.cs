using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Companydelivery
{
    public string Consignee { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public string Company { get; set; } = null!;

    public string? Shippingcontainer { get; set; }

    public bool? Allowmixcontainer { get; set; }

    public int? Delwin1strt { get; set; }

    public int? Delwin1end { get; set; }

    public int? Delwin2strt { get; set; }

    public int? Delwin2end { get; set; }

    public int? Delwin3strt { get; set; }

    public int? Delwin3end { get; set; }

    public int? Delwin4strt { get; set; }

    public int? Delwin4end { get; set; }

    public int? Delwin5strt { get; set; }

    public int? Delwin5end { get; set; }

    public int? Delwin6strt { get; set; }

    public int? Delwin6end { get; set; }

    public int? Delwin7strt { get; set; }

    public int? Delwin7end { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
