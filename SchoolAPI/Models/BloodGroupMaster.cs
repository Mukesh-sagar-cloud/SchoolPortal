using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class BloodGroupMaster
{
    public int BloodGroupId { get; set; }

    public string BloodGroupName { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
