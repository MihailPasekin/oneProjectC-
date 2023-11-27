﻿using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VPlannerInventory
{
    public string Loadid { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string Loaduom { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string? Zpickinglocation { get; set; }

    public string? Destinationlocation { get; set; }

    public string Status { get; set; } = null!;

    public string? Activitystatus { get; set; }

    public decimal? Units { get; set; }

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

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }

    public string? HandlingUnit { get; set; }

    public string? HandlingUnitType { get; set; }

    public string? Sublocation { get; set; }

    public int Accessibility { get; set; }

    public string Pickregion { get; set; } = null!;

    public string Warehousearea { get; set; } = null!;

    public string Locsortorder { get; set; } = null!;

    public string Accesstype { get; set; } = null!;

    public int Accessibleloads { get; set; }

    public string? Pkeytype { get; set; }

    public string? Pkey1 { get; set; }

    public string? Pkey2 { get; set; }

    public string? Pkey3 { get; set; }

    public DateTime? Expirydate { get; set; }

    public decimal? Weight { get; set; }

    public string? Serial { get; set; }

    public bool? Kosher { get; set; }

    public int? Harvest { get; set; }

    public string? Color { get; set; }

    public string? Size { get; set; }

    public string? Batch { get; set; }

    public DateTime? Mfgdate { get; set; }

    public int Score { get; set; }

    public string Locpicktype { get; set; } = null!;

    public string Locaccessibility { get; set; } = null!;

    public double? Loadsvolume { get; set; }

    public string? Wave { get; set; }

    public string? Orderid { get; set; }

    public int HunumLoads { get; set; }
}
