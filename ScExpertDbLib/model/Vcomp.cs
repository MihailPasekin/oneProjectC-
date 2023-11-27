using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Vcomp
{
    public string? Defaultcontact { get; set; }

    public string Consignee { get; set; } = null!;

    public string Company { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public string? Companyname { get; set; }

    public string Street1 { get; set; } = null!;

    public string Street2 { get; set; } = null!;

    public string City { get; set; } = null!;

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? Contact1name { get; set; }

    public string? Contact2name { get; set; }

    public string? Contact1phone { get; set; }

    public string? Contact2phone { get; set; }

    public string? Contact1fax { get; set; }

    public string? Contact2fax { get; set; }

    public string? Contact1email { get; set; }

    public string? Contact2email { get; set; }

    public int Pointed { get; set; }

    public string? Pointid { get; set; }

    public string Objecttype { get; set; } = null!;
}
