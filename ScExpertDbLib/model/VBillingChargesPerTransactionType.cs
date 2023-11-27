using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VBillingChargesPerTransactionType
{
    public string Agreementname { get; set; } = null!;

    public string Trantype { get; set; } = null!;

    public string Trantypedescription { get; set; } = null!;

    public double Billtotal { get; set; }

    public string? Status { get; set; }

    public DateTime Editdate { get; set; }
}
