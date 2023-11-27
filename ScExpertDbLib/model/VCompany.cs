using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VCompany
{
    public string Consignee { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public string Company { get; set; } = null!;

    public string? Companyname { get; set; }

    public string? Othercompany { get; set; }

    public string? Companygroup { get; set; }

    public bool Status { get; set; }

    public bool Mixpicking { get; set; }

    public string? Container { get; set; }

    public string? Defaultcontact { get; set; }

    public string? Prefunloadingside { get; set; }

    public string? Deliverycomments { get; set; }

    public double? Servicetime { get; set; }

    public string? Deliverynotelayout { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }

    public string? Street1 { get; set; }

    public string? Street2 { get; set; }

    public string? State { get; set; }

    public string? City { get; set; }

    public string? Zip { get; set; }
}
