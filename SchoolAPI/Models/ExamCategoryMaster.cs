using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class ExamCategoryMaster
{
    public int ExamCatId { get; set; }

    public string? ExamCatName { get; set; }

    public string? ExamCatDesc { get; set; }

    public int ExamCatCmpId { get; set; }

    public int ExamCatSchId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
