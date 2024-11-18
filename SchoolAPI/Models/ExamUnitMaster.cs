using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class ExamUnitMaster
{
    public int ExamUnitId { get; set; }

    public string? ExamUnitName { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<ScholasticUnitDetail> ScholasticUnitDetails { get; set; } = new List<ScholasticUnitDetail>();
}
