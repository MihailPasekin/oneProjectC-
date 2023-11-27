using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Billingagreementfilter
{
    public int Id { get; set; }

    public string Consignee { get; set; } = null!;

    public string Agreementname { get; set; } = null!;

    public int Agreementline { get; set; }

    public string Fieldname { get; set; } = null!;

    public string Fieldvalue { get; set; } = null!;

    public string Comparisontype { get; set; } = null!;

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
