﻿using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VInvloadsku
{
    public string Loadid { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string Loaduom { get; set; } = null!;

    public string? Loaduomdesc { get; set; }

    public string Location { get; set; } = null!;

    public string? Destinationlocation { get; set; }

    public string Status { get; set; } = null!;

    public string? Statusdesc { get; set; }

    public string? Activitystatus { get; set; }

    public decimal Units { get; set; }

    public decimal Units4wallinv { get; set; }

    public decimal Unitsavailable { get; set; }

    public decimal Unitsonhold { get; set; }

    public decimal Unitsinlimbo { get; set; }

    public decimal Unitsallocated { get; set; }

    public decimal Unitsinprocess { get; set; }

    public decimal Unitspicked { get; set; }

    public string? Receipt { get; set; }

    public int? Receiptline { get; set; }

    public DateTime? Receivedate { get; set; }

    public DateTime? Laststatusdate { get; set; }

    public DateTime? Lastmovedate { get; set; }

    public DateTime? Lastcountdate { get; set; }

    public string? Holdrc { get; set; }

    public string? Prelimbostatus { get; set; }

    public string? Prelimboloc { get; set; }

    public DateTime Adddate { get; set; }

    public string? Lastmoveuser { get; set; }

    public string? Laststatususer { get; set; }

    public string? Lastcountuser { get; set; }

    public string? Laststatusrc { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }

    public string? Handlingunit { get; set; }

    public string? HandlingUnitType { get; set; }

    public string? Sublocation { get; set; }

    public string? Skudesc { get; set; }
}
