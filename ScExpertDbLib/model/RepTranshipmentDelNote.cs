using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class RepTranshipmentDelNote
{
    public string Consignee { get; set; } = null!;

    public string Transshipment { get; set; } = null!;

    public string Ordertype { get; set; } = null!;

    public string? Referenceord { get; set; }

    public string Sourcecompany { get; set; } = null!;

    public string? Sourcecompanytype { get; set; }

    public string Targetcompany { get; set; } = null!;

    public string? Targetcompanytype { get; set; }

    public string? Status { get; set; }

    public DateTime? Statusdate { get; set; }

    public string? Notes { get; set; }

    public DateTime? Createdate { get; set; }

    public DateTime? Scheduledarrivaldate { get; set; }

    public DateTime? Requesteddeliverydate { get; set; }

    public DateTime? Scheduleddeliverydate { get; set; }

    public DateTime? Shippeddate { get; set; }

    public string? Staginglane { get; set; }

    public string? Shipment { get; set; }

    public int? Stopnumber { get; set; }

    public string? Loadingseq { get; set; }

    public string? Routingset { get; set; }

    public string? Route { get; set; }

    public string? Deliverystatus { get; set; }

    public string? Pod { get; set; }

    public int? Orderpriority { get; set; }

    public decimal? Expectedqty { get; set; }

    public decimal? Receivedqty { get; set; }

    public decimal? Expectedweight { get; set; }

    public decimal? Receiveweight { get; set; }

    public string? Sourcecompanyname { get; set; }

    public string? Targetcompanyname { get; set; }

    public string? Consigneename { get; set; }

    public string? Sstreet1 { get; set; }

    public string? Scity { get; set; }

    public string? Szip { get; set; }

    public string? Scontact1name { get; set; }

    public string? Scontact1phone { get; set; }

    public string? Tstreet1 { get; set; }

    public string? Tcity { get; set; }

    public string? Tzip { get; set; }

    public string? Tcontact1name { get; set; }

    public string? Tcontact1phone { get; set; }

    public string? Defaultcontact { get; set; }

    public string? Expr1 { get; set; }
}
