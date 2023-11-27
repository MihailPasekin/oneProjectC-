using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Inboundorderview
{
    public string Consignee { get; set; } = null!;

    public string Orderid { get; set; } = null!;

    public string Ordertype { get; set; } = null!;

    public string? Referenceord { get; set; }

    public string Sourcecompany { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public string? Status { get; set; }

    public DateTime? Createdate { get; set; }

    public string? Notes { get; set; }

    public string? Sku { get; set; }

    public string Companyname { get; set; } = null!;

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }

    public DateTime? Expecteddate { get; set; }

    public string Receivedfrom { get; set; } = null!;

    public string? Hostorderid { get; set; }

    public int Fullyreceived { get; set; }
}
