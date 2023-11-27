using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VLoadingContainer
{
    public string Shipment { get; set; } = null!;

    public string? Companyname { get; set; }

    public string Targetcompany { get; set; } = null!;

    public DateTime Requesteddate { get; set; }

    public string Loadingseq { get; set; } = null!;

    public string Routingset { get; set; } = null!;

    public string Route { get; set; } = null!;

    public string Carrier { get; set; } = null!;

    public string Carriername { get; set; } = null!;

    public string? Door { get; set; }

    public string? Vehicle { get; set; }

    public string? Trailer { get; set; }

    public string? Seal1 { get; set; }

    public string? Seal2 { get; set; }

    public string? Driver1 { get; set; }

    public string? Notes { get; set; }

    public string? Bol { get; set; }

    public string? Transporttype { get; set; }

    public string? Transportreference { get; set; }

    public string Containerid { get; set; } = null!;

    public string Loadid { get; set; } = null!;

    public int Orderline { get; set; }

    public string Picklist { get; set; } = null!;

    public int Picklistline { get; set; }

    public string? Fromlocation { get; set; }

    public string Orderid { get; set; } = null!;

    public string Consignee { get; set; } = null!;

    public decimal Units { get; set; }
}
