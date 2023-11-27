using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Billingagreementdetail
{
    public string Agreementname { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public int Line { get; set; }

    public int? Pluginid { get; set; }

    public string Billbasis { get; set; } = null!;

    public decimal Priceperunit { get; set; }

    public string? Pricelist { get; set; }

    public decimal Minpertran { get; set; }

    public decimal? Maxpertran { get; set; }

    public decimal Minperrun { get; set; }

    public decimal? Maxperrun { get; set; }

    public string Periodtype { get; set; } = null!;

    public string Period { get; set; } = null!;

    public string? Runcondition { get; set; }

    public string? Storageperiodtime { get; set; }

    public string? Storageperiodtype { get; set; }

    public DateTime? Enddate { get; set; }

    public string? Chargedescription { get; set; }

    public string? Handlingunittype { get; set; }

    public bool? Storagepartialperiod { get; set; }

    public bool? Isstoragerange { get; set; }

    public string? Priceequation { get; set; }

    public int? Storagegracedays { get; set; }

    public DateTime Startdate { get; set; }

    public DateTime Lastrundate { get; set; }

    public DateTime Nextrundate { get; set; }

    public bool? Active { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
