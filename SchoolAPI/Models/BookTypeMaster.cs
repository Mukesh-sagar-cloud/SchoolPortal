﻿using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class BookTypeMaster
{
    public int BookTypeId { get; set; }

    public string? BookTypeName { get; set; }

    public string? BookTypeDescription { get; set; }

    public bool? BookTypeIsActive { get; set; }

    public int BookTypeCmpId { get; set; }

    public int BookTypeSchId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateOnly CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<BookMaster> BookMasters { get; set; } = new List<BookMaster>();
}