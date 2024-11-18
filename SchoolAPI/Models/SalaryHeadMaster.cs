using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class SalaryHeadMaster
{
    public int SalhmId { get; set; }

    public string? SalhmCode { get; set; }

    public string? SalhmDescription { get; set; }

    public bool? SalhmIsReadonly { get; set; }

    public string SalhmType { get; set; } = null!;

    public bool SalhmIsDeduction { get; set; }

    public bool SalhmIsActive { get; set; }

    public int SalhmCmpId { get; set; }

    public int SalhmSchId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<SalaryDesigGradeDetail> SalaryDesigGradeDetails { get; set; } = new List<SalaryDesigGradeDetail>();

    public virtual ICollection<SalaryDesigGradeDetailsHistory> SalaryDesigGradeDetailsHistories { get; set; } = new List<SalaryDesigGradeDetailsHistory>();
}
