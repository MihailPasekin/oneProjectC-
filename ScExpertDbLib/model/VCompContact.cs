using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VCompContact
{
    public string Consignee { get; set; } = null!;

    public string Company { get; set; } = null!;

    public string Companytype { get; set; } = null!;

    public string Contactid { get; set; } = null!;

    public string? Contacttype { get; set; }

    public string? Deliverysite { get; set; }

    public string? Pickupsite { get; set; }

    public string? Checkpointsite { get; set; }

    public string? Route { get; set; }

    public int? EarlyArrivalService { get; set; }

    public int? Fixedservicetime { get; set; }

    public string? Deliveryconfirmationtype { get; set; }

    public string? Pickupconfirmationtype { get; set; }

    public DateTime Adddate { get; set; }

    public string Adduser { get; set; } = null!;

    public DateTime Editdate { get; set; }

    public string Edituser { get; set; } = null!;

    public string? Street1 { get; set; }

    public string? Street2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? Pointid { get; set; }
}
