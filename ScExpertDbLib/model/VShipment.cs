﻿using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VShipment
{
    public string Shipment { get; set; } = null!;

    public string? Status { get; set; }

    public string? Statusdesc { get; set; }

    public DateTime? Createdate { get; set; }

    public DateTime? Scheddate { get; set; }

    public DateTime? Startloadingdate { get; set; }

    public DateTime? Shippeddate { get; set; }

    public string? Door { get; set; }

    public string? Carrier { get; set; }

    public string? Carriername { get; set; }

    public string? Vehicle { get; set; }

    public string? Trailer { get; set; }

    public string? Seal1 { get; set; }

    public string? Seal2 { get; set; }

    public string? Driver1 { get; set; }

    public string? Driver2 { get; set; }

    public string? Notes { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }

    public string? Transportreference { get; set; }

    public string? Transporttype { get; set; }

    public string? Bol { get; set; }

    public string? YardAppointmentId { get; set; }

    public double? Ordervolume { get; set; }

    public double? Orderweight { get; set; }

    public DateTime? Scheduledate { get; set; }
}
