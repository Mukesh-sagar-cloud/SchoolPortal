using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class SmstaskStatusMaster
{
    public int StssmId { get; set; }

    public string? StssmName { get; set; }

    public bool? StssmIsActive { get; set; }

    public int StssmCmpId { get; set; }

    public int StssmSchId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
