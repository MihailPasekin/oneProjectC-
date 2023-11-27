using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class TalkmanGetPick
{
    public string Picklist { get; set; } = null!;

    public int Picklistline { get; set; }

    public int CountFlag { get; set; }

    public string Location { get; set; } = null!;

    public string? Checkdigits { get; set; }

    public string? LoadId { get; set; }

    public decimal? Quantity { get; set; }

    public string? Uom { get; set; }

    public int Uomtobaseuom { get; set; }

    public string? Sku { get; set; }

    public string? Skudesc { get; set; }

    public string? Upc { get; set; }

    public int? Containerseqnum { get; set; }

    public double? Netweight { get; set; }

    public int Verifyloadid { get; set; }

    public int Captureweight { get; set; }

    public int WeightStartPosition { get; set; }

    public int WeightLength { get; set; }

    public int DecimalDigits { get; set; }

    public string Separator { get; set; } = null!;

    public int Captureserial { get; set; }

    public int SerialStartPosition { get; set; }

    public int SerialLength { get; set; }

    public int Capturelot { get; set; }

    public int LotStartPosition { get; set; }

    public int LotLength { get; set; }

    public double? Averageweight { get; set; }

    public int Tolerance { get; set; }

    public string Picklistid { get; set; } = null!;

    public string? Fromload { get; set; }
}
