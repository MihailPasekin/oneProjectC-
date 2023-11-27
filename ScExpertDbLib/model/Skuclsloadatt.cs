using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class Skuclsloadatt
{
    public string Classname { get; set; } = null!;

    public string Attributename { get; set; } = null!;

    public string Receivingcapture { get; set; } = null!;

    public string? Receivingvalidator { get; set; }

    public string Pickingcapture { get; set; } = null!;

    public string? Pickingvalidator { get; set; }

    public string? Verificationcapture { get; set; }

    public string? Verificationvalidator { get; set; }

    public string? Countingcapture { get; set; }

    public string? Countingvalidator { get; set; }

    public DateTime Adddate { get; set; }

    public string? Adduser { get; set; }

    public DateTime Editdate { get; set; }

    public string? Edituser { get; set; }
}
