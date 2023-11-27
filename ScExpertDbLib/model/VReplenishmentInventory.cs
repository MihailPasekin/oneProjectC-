using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VReplenishmentInventory
{
    public string Loadid { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string Loaduom { get; set; } = null!;

    public string Touom { get; set; } = null!;

    public string? Loaduomdesc { get; set; }

    public string Location { get; set; } = null!;

    public string? Destinationlocation { get; set; }

    public string Status { get; set; } = null!;

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

    public string? Putregion { get; set; }

    public string? Pickregion { get; set; }

    public string? Warehousearea { get; set; }

    public string? Aisle { get; set; }

    public string? Locsortorder { get; set; }

    public string? Loctpickype { get; set; }

    public string? Locstoragetype { get; set; }

    public string? Locusagetype { get; set; }

    public string? Locmhtype { get; set; }

    public bool Inventory { get; set; }

    public string Accesstype { get; set; } = null!;

    public int? Accessibleloads { get; set; }

    public double? Length { get; set; }

    public double? Width { get; set; }

    public double? Height { get; set; }

    public double? Locationweight { get; set; }

    public double? Cubic { get; set; }

    public int Loadscapacity { get; set; }

    public double? Pendingweight { get; set; }

    public double? Pendingcubic { get; set; }

    public int? Pendingloads { get; set; }

    public string? Checkdigits { get; set; }

    public bool Looseid { get; set; }

    public string? Bay { get; set; }

    public int? Loclevel { get; set; }

    public double? Heightfromfloor { get; set; }

    public DateTime? Lastmovein { get; set; }

    public DateTime? Lastmoveout { get; set; }

    public int? Picksfromlastcount { get; set; }

    public int? Xcoordinate { get; set; }

    public int? Ycoordinate { get; set; }

    public int? Zcoordinate { get; set; }

    public string? Inhandoff { get; set; }

    public string? Outhandoff { get; set; }

    public string? Laborhufacing { get; set; }

    public string? Laborinserttype { get; set; }

    public string? Laborretrievetype { get; set; }

    public string? Laborpicktype { get; set; }

    public string? Laborreachtype { get; set; }

    public string? Congestionregion { get; set; }

    public bool Problemflag { get; set; }

    public string? Hustoragetemplate { get; set; }

    public string? Locaccessibility { get; set; }

    public int? Accessibility { get; set; }

    public int Score { get; set; }

    public decimal SortColumn { get; set; }
}
