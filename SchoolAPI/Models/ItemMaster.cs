using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class ItemMaster
{
    public int ItemId { get; set; }

    public string? ItemName { get; set; }

    public string? ItemDescription { get; set; }

    public int? ItemTypeMasterId { get; set; }

    public bool? ItemIsActive { get; set; }

    public int ItemCmpId { get; set; }

    public int ItemSchId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<InventoryMaster> InventoryMasters { get; set; } = new List<InventoryMaster>();

    public virtual ItemTypeMaster? ItemTypeMaster { get; set; }
}
