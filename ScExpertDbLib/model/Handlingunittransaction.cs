using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Handlingunittransaction
{
    public string Transactionid { get; set; } = null!;

    public string? Transactiontype { get; set; }

    public string? Transactiontypeid { get; set; }

    public DateTime Transactiondate { get; set; }

    public string? Consignee { get; set; }

    public string? Orderid { get; set; }

    public string? Documenttype { get; set; }

    public string? Company { get; set; }

    public string? Companytype { get; set; }

    public string? Hutype { get; set; }

    public decimal? Huqty { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
