using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolAPI.Models;
using SchoolAPI.CustomClasses;
using Response = SchoolAPI.CustomClasses.Response;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace SchoolAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeptMasterController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly SchoolMangementSystemContext dbContext;

        public DeptMasterController(IMapper mapper, SchoolMangementSystemContext context)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            dbContext = context ?? throw new ArgumentNullException(nameof(context));
        }

        [HttpGet("GetAllDepartments")]
        public ActionResult<List<object>> GetAllDepartments()
        {
            var departments = dbContext.DeptMasters
                .Join(
                    dbContext.CompanyMasters,
                    dept => dept.DeptCmpId,
                    comp => comp.CmpId,
                    (dept, comp) => new { dept, comp }
                )
                .Join(
                    dbContext.SchoolMasters,
                    temp => temp.dept.DeptSchId,
                    sch => sch.SchId,
                    (temp, sch) => new
                    {
                        temp.dept.DeptId,
                        temp.dept.DeptCode,
                        temp.dept.DeptName,
                        CompanyCode = temp.comp.CmpDescription,
                        SchoolCode = sch.SchName,
                        temp.dept.DeptIsActive,
                        temp.dept.CreatedBy,
                        temp.dept.CreatedDate,
                        temp.dept.ModifiedBy,
                        temp.dept.ModifiedDate
                    }
                )
                .ToList();

            return Ok(departments);
        }

        [HttpGet("GetAllDepartmentsBySchoolID")]
        public ActionResult<List<object>> GetAllDepartmentsBySchoolID(int cmpId, int schId)
        {
            if (cmpId <= 0 || schId <= 0)
                return BadRequest(new { Status = "Error", Message = "Invalid School or Company ID." });

            var departments = dbContext.DeptMasters
                .Join(
                    dbContext.CompanyMasters,
                    dept => dept.DeptCmpId,
                    comp => comp.CmpId,
                    (dept, comp) => new { dept, comp }
                )
                .Join(
                    dbContext.SchoolMasters,
                    temp => temp.dept.DeptSchId,
                    sch => sch.SchId,
                    (temp, sch) => new
                    {
                        temp.dept.DeptId,
                        temp.dept.DeptCode,
                        temp.dept.DeptName,
                        CompanyCode = temp.comp.CmpDescription,
                        SchoolCode = sch.SchName,
                        temp.dept.DeptIsActive,
                        temp.dept.CreatedBy,
                        temp.dept.CreatedDate,
                        temp.dept.ModifiedBy,
                        temp.dept.ModifiedDate,
                        CmpId = temp.comp.CmpId,
                        SchId = temp.dept.DeptSchId
                    }
                )
                .Where(x => x.CmpId == cmpId && x.SchId == schId)
                .ToList();

            return Ok(departments);
        }

        [HttpGet("GetDepartmentByName")]
        public ActionResult<object> GetDepartmentByName(int cmpId, int schId, string deptName)
        {
            if (string.IsNullOrEmpty(deptName))
                return BadRequest(new { Status = "Error", Message = "Department name cannot be empty." });

            var department = dbContext.DeptMasters
                .Where(d => d.DeptCmpId == cmpId && d.DeptSchId == schId && d.DeptName == deptName)
                .Select(d => new
                {
                    d.DeptId,
                    d.DeptCode,
                    d.DeptName,
                    d.DeptCmpId,
                    d.DeptSchId,
                    d.DeptIsActive,
                    d.CreatedBy,
                    d.CreatedDate,
                    d.ModifiedBy,
                    d.ModifiedDate
                })
                .FirstOrDefault();

            if (department == null)
                return NotFound(new { Status = "Error", Message = "Department not found." });

            return Ok(department);
        }

        [HttpPost("AddDepartment")]
        public IActionResult AddDepartment([FromBody] DepartmentDto departmentDto)
        {
            if (departmentDto == null)
                return BadRequest(new { Status = "Error", Message = "Invalid department data." });

            if (string.IsNullOrEmpty(departmentDto.DeptName))
                return BadRequest(new { Status = "Error", Message = "Department name is required." });

            try
            {
                var department = _mapper.Map<DeptMaster>(departmentDto);

                dbContext.DeptMasters.Add(department);
                dbContext.SaveChanges();

                return Ok(new { Status = "Success", Message = "Department added successfully." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Status = "Error", Message = ex.Message });
            }
        }

        [HttpPut("UpdateDepartment")]
        public IActionResult UpdateDepartment(int id, [FromBody] DepartmentDto departmentDto)
        {
            if (id <= 0)
                return BadRequest(new { Status = "Error", Message = "Invalid Department ID." });

            if (departmentDto == null)
                return BadRequest(new { Status = "Error", Message = "Invalid department data." });

            try
            {
                var existingDepartment = dbContext.DeptMasters.Find(id);

                if (existingDepartment == null)
                    return NotFound(new { Status = "Error", Message = "Department not found." });

                _mapper.Map(departmentDto, existingDepartment);
                dbContext.SaveChanges();

                return Ok(new { Status = "Success", Message = "Department updated successfully." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Status = "Error", Message = ex.Message });
            }
        }

        [HttpDelete("DeleteDepartment")]
        public ActionResult<Response> DeleteDepartment(int deptId)
        {
            if (deptId <= 0)
                return BadRequest(new { Status = "Error", Message = "Invalid Department ID." });

            var existingDept = dbContext.DeptMasters
                .FirstOrDefault(d => d.DeptId == deptId && d.DeptIsActive);

            if (existingDept == null)
                return NotFound(new Response { Status = "Failure", Message = "Department not found." });

            existingDept.DeptIsActive = false;
            existingDept.ModifiedDate = DateTime.Now;

            dbContext.SaveChanges();

            return Ok(new Response { Status = "Success", Message = "Department deleted successfully." });
        }
    }
}
