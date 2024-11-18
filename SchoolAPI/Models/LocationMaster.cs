using System;
using System.Collections.Generic;

namespace SchoolAPI.Models;

public partial class LocationMaster
{
    public int LocId { get; set; }

    public string? LocCode { get; set; }

    public string? LocName { get; set; }

    public string? LocCity { get; set; }

    public bool LocIsActive { get; set; }

    public int LocCmpId { get; set; }

    public int LocSchId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual ICollection<RouteMaster> RouteMasterRouteEndLocations { get; set; } = new List<RouteMaster>();

    public virtual ICollection<RouteMaster> RouteMasterRouteStartLocations { get; set; } = new List<RouteMaster>();

    public virtual ICollection<RouteStopDetail> RouteStopDetails { get; set; } = new List<RouteStopDetail>();
}
