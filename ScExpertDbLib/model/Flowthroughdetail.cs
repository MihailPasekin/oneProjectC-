using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Flowthroughdetail
{
    public string Consignee { get; set; } = null!;

    public string Flowthrough { get; set; } = null!;

    public string Flowthroughline { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public decimal? Qtyoriginal { get; set; }

    public decimal? Qtymodified { get; set; }

    public decimal? Qtyreceived { get; set; }

    public decimal? Qtypicked { get; set; }

    public decimal? Qtystaged { get; set; }

    public decimal? Qtypacked { get; set; }

    public decimal? Qtyloaded { get; set; }

    public decimal? Qtyverified { get; set; }

    public decimal? Qtyshipped { get; set; }

    public decimal? Inputqty { get; set; }

    public string? Inventorystatus { get; set; }

    public string? Inputsku { get; set; }

    public string? Inputuom { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
