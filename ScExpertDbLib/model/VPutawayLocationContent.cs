using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VPutawayLocationContent
{
    public string Loadid { get; set; } = null!;

    public string? Handlingunit { get; set; }

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

    public string? Sublocation { get; set; }

    public bool Looseid { get; set; }

    public string? Locstoragetype { get; set; }

    public bool Inventory { get; set; }

    public double? Length { get; set; }

    public double? Width { get; set; }

    public double? Height { get; set; }

    public double? Cubic { get; set; }

    public double? Weight { get; set; }

    public int Loadscapacity { get; set; }

    public int Score { get; set; }

    public string? Locaccessibility { get; set; }

    public int Numloads { get; set; }

    public int PendingLoads { get; set; }

    public double TotalVolume { get; set; }

    public double TotalWeight { get; set; }

    public double Pendingvolume { get; set; }

    public double Pendingweight { get; set; }

    public string? Putregion { get; set; }

    public string Hustoragetemplate { get; set; } = null!;

    public string? Warehousearea { get; set; }

    public int? Loclevel { get; set; }
}
