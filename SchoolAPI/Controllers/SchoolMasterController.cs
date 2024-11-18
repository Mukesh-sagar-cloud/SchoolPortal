using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolAPI.Models;
using SchoolAPI.CustomClasses;
using Response = SchoolAPI.CustomClasses.Response;

namespace SchoolAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SchoolMasterController : ControllerBase
	{
		private readonly SchoolMangementSystemContext dbContext;

		public SchoolMasterController(SchoolMangementSystemContext context)
		{
			dbContext = context ?? throw new ArgumentNullException(nameof(context));
		}

		[HttpGet("GetAll")]
		public ActionResult<List<SchoolMaster>> GetAll()
		{
			var schoolMasterList = dbContext.SchoolMasters.ToList();
			return Ok(schoolMasterList);
		}

		
			[HttpGet("GetSchoolByCompany")]
		public ActionResult<List<SchoolMaster>> GetSchoolByCompany(int cmpId)
		{
			var schoolMasterList = dbContext.SchoolMasters.Where(p => p.SchCmpId == cmpId).ToList();
			return Ok(schoolMasterList);
		}
	}
}
