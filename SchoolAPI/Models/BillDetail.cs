using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class BillDetail
{
    public int BillDetailId { get; set; }

    public int BillDetailBillId { get; set; }

    public int? BillDetailExpCatId { get; set; }

    public string? BillDetailDesc { get; set; }

    public int? BillDetailQty { get; set; }

    public decimal? BillDetailAmount { get; set; }

    public int BillCmpId { get; set; }

    public int BillSchId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual BillMaster BillDetailBill { get; set; } = null!;

    public virtual ExpenseCategoryMaster? BillDetailExpCat { get; set; }
}
