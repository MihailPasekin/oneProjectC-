using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class RepCompanyByConsigee
{
    public string Company { get; set; } = null!;

    public string? Companyname { get; set; }

    public string Companytype { get; set; } = null!;

    public string? Othercompany { get; set; }

    public string? Companygroup { get; set; }

    public string? Street1 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string Consignee { get; set; } = null!;
}
