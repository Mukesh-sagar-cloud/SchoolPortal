﻿using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class StudentReportCardMaster
{
    public int RepcardId { get; set; }

    public Guid RepcardStuGuid { get; set; }

    public int RepcardCmId { get; set; }

    public int RepcardSecId { get; set; }

    public string? RepcardSession { get; set; }

    public string? RepcardType { get; set; }

    public string? RepcardTypeValue { get; set; }

    public DateTime? RepcardPeriod { get; set; }

    public int? RepcardCmpId { get; set; }

    public int? RepcardSchId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
