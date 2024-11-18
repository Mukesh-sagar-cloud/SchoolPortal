using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class CountryMaster
{
    public int CountryId { get; set; }

    public string? CountryName { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<StateMaster> StateMasters { get; set; } = new List<StateMaster>();
}
