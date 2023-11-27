using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Transportationorder
{
    public string Consignee { get; set; } = null!;

    public string Transportationorderid { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime Createdate { get; set; }

    public DateTime? Draftcreatedate { get; set; }

    public string? Referenceorder { get; set; }

    public string? Hostorderid { get; set; }

    public string Sourcecompany { get; set; } = null!;

    public string Sourcecompanytype { get; set; } = null!;

    public string? Sourcecontactid { get; set; }

    public string Targetcompany { get; set; } = null!;

    public string Targetcompanytype { get; set; } = null!;

    public string? Targetcontactid { get; set; }

    public DateTime? Requestedpickupdate { get; set; }

    public DateTime? Requesteddeliverydate { get; set; }

    public string? Ordertype { get; set; }

    public string? Hazardclass { get; set; }

    public string? Transportationclass { get; set; }

    public int? Orderpriority { get; set; }

    public string? Transportationtype { get; set; }

    public string? Cargotype { get; set; }

    public string? Deliveryconfirmationtype { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;
}
