using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Serviceleveldefinition
{
    public string Consignee { get; set; } = null!;

    public string Company { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public string Contactid { get; set; } = null!;

    public string? Companycontacttype { get; set; }

    public string? Documenttype { get; set; }

    public string? Ordertype { get; set; }

    public string? Companygroup { get; set; }

    public string? Servicetype { get; set; }

    public decimal Servicetime { get; set; }

    public int Priority { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
