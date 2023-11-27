using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VLoadingNoteAddSku
{
    public string Consignee { get; set; } = null!;

    public string Orderid { get; set; } = null!;

    public int Orderline { get; set; }

    public string Sku { get; set; } = null!;

    public string? Skudesc { get; set; }

    public decimal? Qtymodified { get; set; }

    public decimal? Units { get; set; }

    public string Container { get; set; } = null!;
}
