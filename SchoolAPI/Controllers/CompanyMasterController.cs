using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolAPI.Models;
using SchoolAPI.CustomClasses;
using Response = SchoolAPI.CustomClasses.Response;

namespace SchoolAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CompanyMasterController : ControllerBase
	{
		private readonly SchoolMangementSystemContext dbContext;

		public CompanyMasterController(SchoolMangementSystemContext context)
		{
			dbContext = context ?? throw new ArgumentNullException(nameof(context));
		}

		[HttpGet("GetAll")]
		public ActionResult<List<CompanyMaster>> GetAll()
		{
			var companyMasterList = dbContext.CompanyMasters.ToList();
			return Ok(companyMasterList);
		}
	}
}
