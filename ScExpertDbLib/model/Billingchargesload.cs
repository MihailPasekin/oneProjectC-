using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Billingchargesload
{
    public string Chargeid { get; set; } = null!;

    public string Chargeline { get; set; } = null!;

    public string Transactiondate { get; set; } = null!;

    public string Loadid { get; set; } = null!;

    public string? Transactiontype { get; set; }

    public string? Consignee { get; set; }

    public string? Sku { get; set; }

    public string? Uom { get; set; }

    public decimal? Unitprice { get; set; }

    public decimal? Units { get; set; }

    public decimal? Unitsperuom { get; set; }

    public decimal? Uomvolume { get; set; }

    public decimal? Uomweight { get; set; }
}
