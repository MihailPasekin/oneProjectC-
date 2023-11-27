using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class RepShipList
{
    public string ShipmentId { get; set; } = null!;

    public string? Vehicle { get; set; }

    public string? Notes { get; set; }

    public string? Door { get; set; }

    public string? Driver1 { get; set; }

    public string Orderid { get; set; } = null!;

    public string? Street1 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? Location { get; set; }

    public string Containerid { get; set; } = null!;

    public string? Hutype { get; set; }

    public string Containerdesc { get; set; } = null!;

    public string? Companyname { get; set; }
}
