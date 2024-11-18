namespace SchoolAPI.CustomClasses
{
    public class DepartmentDto
    {
        public int DeptId { get; set; }
        public string? DeptCode { get; set; }
        public string? DeptName { get; set; }
        public int? DeptCmpId { get; set; }
        public int DeptSchId { get; set; }
        public bool DeptIsActive { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
