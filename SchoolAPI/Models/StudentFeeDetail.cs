using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class StudentFeeDetail
{
    public int StudfeeId { get; set; }

    public Guid StudfeeStuGuid { get; set; }

    public int StudfeeCmId { get; set; }

    public DateTime StudFeeDueDate { get; set; }

    public DateTime? StudFeeDate { get; set; }

    public bool StudFeesPaid { get; set; }

    public decimal? StudFeeAmount { get; set; }

    public decimal? StudLateFeeAmount { get; set; }

    public decimal? StudFeeTotalAmount { get; set; }

    public long? StudFeeIsActive { get; set; }

    public int StudFeeMonth { get; set; }

    public int StudFeeYear { get; set; }

    public int StudSchId { get; set; }

    public int StudCmpId { get; set; }

    public string? StudFeeReceiptNumber { get; set; }

    public int? StudFeeCatId { get; set; }

    public int? StudfeeSecId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
