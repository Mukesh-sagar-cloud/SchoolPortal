using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class StateMaster
{
    public int StateId { get; set; }

    public string? StateName { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? StateCountryId { get; set; }

    public virtual CountryMaster? StateCountry { get; set; }
}
