using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Inboundorddetail
{
    public string Consignee { get; set; } = null!;

    public string Orderid { get; set; } = null!;

    public int Orderline { get; set; }

    public string? Referenceordline { get; set; }

    public DateTime? Expecteddate { get; set; }

    public DateTime? Lastreceiptdate { get; set; }

    public string? Sku { get; set; }

    public decimal? Qtyordered { get; set; }

    public decimal? Qtyadjusted { get; set; }

    public decimal? Qtyreceived { get; set; }

    public string? Inputuom { get; set; }

    public decimal? Inputqty { get; set; }

    public string? Inputsku { get; set; }

    public string? Inventorystatus { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
