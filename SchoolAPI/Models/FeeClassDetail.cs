using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class FeeClassDetail
{
    public int FcdId { get; set; }

    public int FcdCmId { get; set; }

    public int FcdFeeCatId { get; set; }

    public DateTime FcdFromDate { get; set; }

    public DateTime FcdToDate { get; set; }

    public decimal? FcdAmount { get; set; }

    public bool FcdIsActive { get; set; }

    public int? FcdSchId { get; set; }

    public int? FcdCmpId { get; set; }

    public string? FcdSession { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
