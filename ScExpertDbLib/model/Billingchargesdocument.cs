using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Billingchargesdocument
{
    public string Chargeid { get; set; } = null!;

    public int Chargeline { get; set; }

    public string Transactiontype { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string Orderid { get; set; } = null!;

    public decimal Units { get; set; }

    public decimal Value { get; set; }
}
