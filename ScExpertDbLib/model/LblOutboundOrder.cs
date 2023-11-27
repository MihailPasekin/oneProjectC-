﻿using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class LblOutboundOrder
{
    public string Consignee { get; set; } = null!;

    public string Orderid { get; set; } = null!;

    public string Ordertype { get; set; } = null!;

    public string? Ordertypedesc { get; set; }

    public string? Staginglane { get; set; }

    public DateTime? Shippeddate { get; set; }

    public DateTime? Requesteddate { get; set; }

    public string? Shipment { get; set; }

    public int? Stopnumber { get; set; }

    public string? Wave { get; set; }

    public string Company { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public string? Companyname { get; set; }

    public string? Comptypedesc { get; set; }

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

    public string? Defaultcontact { get; set; }
}
