using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class ReligionMaster
{
    public int ReligionId { get; set; }

    public string? ReligionName { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
