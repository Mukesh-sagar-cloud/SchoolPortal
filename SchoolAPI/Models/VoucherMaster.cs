using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class VoucherMaster
{
    public int VoucherId { get; set; }

    public string? VoucherNumber { get; set; }

    public string? VoucherName { get; set; }

    public string? VoucherDescription { get; set; }

    public DateTime VoucherDate { get; set; }

    public decimal? VoucherAmount { get; set; }

    public int VoucherExpenseCategoryId { get; set; }

    public bool? VoucherIsActive { get; set; }

    public int VoucherCmpId { get; set; }

    public int VoucherSchId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ExpenseCategoryMaster VoucherExpenseCategory { get; set; } = null!;
}
