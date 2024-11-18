using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class FeesCategoryMaster
{
    public int FcmId { get; set; }

    public string? FcmCatName { get; set; }

    public string? FcmCatDescription { get; set; }

    public bool? FcmCatIsActive { get; set; }

    public int? FcmCatSchId { get; set; }

    public int? FcmCatCmpId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<FeeClassDetailsHistory> FeeClassDetailsHistories { get; set; } = new List<FeeClassDetailsHistory>();
}
