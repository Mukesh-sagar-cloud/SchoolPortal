using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class FeesDiscountCategoryMaster
{
    public int FdcmId { get; set; }

    public string? FdcmName { get; set; }

    public string? FdcmDescription { get; set; }

    public bool? FdcmIsActive { get; set; }

    public int FdcmCmpId { get; set; }

    public int FdcmSchId { get; set; }

    public decimal? FdcmAmount { get; set; }

    public int? FdcmFeeCatId { get; set; }

    public bool? FdcmIsPercentage { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
