using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VCompanyContact
{
    public string Consignee { get; set; } = null!;

    public string Company { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public string Contactid { get; set; } = null!;

    public string? Street1 { get; set; }

    public string? Street2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Country { get; set; }

    public string? Zip { get; set; }

    public string? Contact1name { get; set; }

    public string? Contact2name { get; set; }

    public string? Contact1phone { get; set; }

    public string? Contact2phone { get; set; }

    public string? Contact1fax { get; set; }

    public string? Contact2fax { get; set; }

    public string? Contact1email { get; set; }

    public string? Contact2email { get; set; }

    public string? Pointid { get; set; }

    public string? Route { get; set; }

    public string? Staginglane { get; set; }

    public string? Pickupconfirmationtype { get; set; }

    public string? Deliveryconfirmationtype { get; set; }

    public string? Companyname { get; set; }

    public string? Othercompany { get; set; }

    public string? Companygroup { get; set; }

    public bool Status { get; set; }

    public bool Mixpicking { get; set; }

    public string? Container { get; set; }

    public string? Prefunloadingside { get; set; }

    public string? Deliverycomments { get; set; }

    public double? Servicetime { get; set; }

    public string? Deliverynotelayout { get; set; }

    public string? Defaultcontact { get; set; }

    public int? Fixedservicetime { get; set; }

    public string? Address { get; set; }

    public string? Contacttype { get; set; }

    public string? Deliverysite { get; set; }

    public string? Pickupsite { get; set; }

    public string? Checkpointsite { get; set; }

    public int? EarlyArrivalService { get; set; }
}
