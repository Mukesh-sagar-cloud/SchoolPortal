﻿using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class LeaveStatusMaster
{
    public int LeaveStatusId { get; set; }

    public string? LeaveStatusName { get; set; }

    public string? LeaveStatusDescription { get; set; }

    public bool LeaveStatusIsActive { get; set; }

    public int LeaveStatusCmpId { get; set; }

    public int LeaveStatusSchId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<EmpLeaveAvailDetail> EmpLeaveAvailDetails { get; set; } = new List<EmpLeaveAvailDetail>();
}