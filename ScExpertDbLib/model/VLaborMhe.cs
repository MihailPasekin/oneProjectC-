using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VLaborMhe
{
    public string Mheid { get; set; } = null!;

    public string Mhetype { get; set; } = null!;

    public double WalkConstant { get; set; }

    public double WalkVariable { get; set; }

    public double SlowConstant { get; set; }

    public double SlowVariable { get; set; }

    public double FastConstant { get; set; }

    public double FastVariable { get; set; }

    public double UpConstant { get; set; }

    public double UpVariable { get; set; }

    public double DownConstant { get; set; }

    public double DownVariable { get; set; }

    public double InsertRetrieveConstant { get; set; }

    public double HorizontalWeightConstant { get; set; }

    public double HorizontalWeightVariable { get; set; }

    public double VerticlaWeightconstant { get; set; }

    public double VerticlaWeightVariable { get; set; }

    public double WalkThresHold { get; set; }

    public double SlowThresHold { get; set; }

    public double FastThresHold { get; set; }

    public double Horizontalconstant { get; set; }

    public double HorizontalVariable { get; set; }
}
