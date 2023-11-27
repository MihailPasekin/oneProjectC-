using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VPackingListHeader
{
    public string Packinglistid { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string? Consigneename { get; set; }

    public string Company { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public string? Companytypedesc { get; set; }

    public string Contactid { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Statusdesc { get; set; }

    public int? Numpackages { get; set; }

    public string? Companyname { get; set; }

    public string? Street1 { get; set; }

    public string? Street2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? Contact1name { get; set; }

    public string? Contact2name { get; set; }

    public string? Contact1phone { get; set; }

    public string? Contact2phone { get; set; }

    public string? Contact1email { get; set; }
}
