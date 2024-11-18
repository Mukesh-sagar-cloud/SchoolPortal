using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class EmpProfQualiDetail
{
    public int EpqualdEmpId { get; set; }

    public int EpqualdQualId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual EmpMaster EpqualdEmp { get; set; } = null!;

    public virtual QualificationMaster EpqualdQual { get; set; } = null!;
}
