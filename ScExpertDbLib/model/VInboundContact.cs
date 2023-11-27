using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VInboundContact
{
    public string Consignee { get; set; } = null!;

    public string Orderid { get; set; } = null!;

    public string Contactid { get; set; } = null!;

    public string? Street1 { get; set; }

    public string? Street2 { get; set; }

    public string? City { get; set; }

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

    public string? Pointid { get; set; }

    public string? Staginglane { get; set; }

    public string? Pickupconfirmationtype { get; set; }

    public string? Deliveryconfirmationtype { get; set; }

    public string? Route { get; set; }
}
