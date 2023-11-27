using System;
using System.Collections.Generic;

namespace ScExpertDbLib.model;

public partial class VLaborTask
{
    public string Task { get; set; } = null!;

    public string TaskType { get; set; } = null!;

    public string TaskConsignee { get; set; } = null!;

    public string TaskSku { get; set; } = null!;

    public string TaskFromLocation { get; set; } = null!;

    public string TaskToLocation { get; set; } = null!;

    public string TaskFromLoad { get; set; } = null!;

    public string TaskFromContainer { get; set; } = null!;

    public string TaskToContainer { get; set; } = null!;

    public string TaskToLoad { get; set; } = null!;

    public string TaskPickList { get; set; } = null!;

    public string TaskParallelPickList { get; set; } = null!;

    public string TaskReplenishment { get; set; } = null!;

    public string TaskUser { get; set; } = null!;

    public string TaskAssigmentLocation { get; set; } = null!;

    public string TaskMhe { get; set; } = null!;

    public string TaskTerminalType { get; set; } = null!;

    public decimal TaskTypeGenericTime { get; set; }

    public int TaskActualTime { get; set; }

    public DateTime? TaskStartDate { get; set; }

    public DateTime? TaskEndDate { get; set; }
}
