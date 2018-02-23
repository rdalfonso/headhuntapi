using System; using System.Collections.Generic; using System.Linq; using System.Threading.Tasks; using Microsoft.AspNetCore.Mvc; using headhuntapi.Models; using headhuntapi.Services; using headhuntapi.Models.Dtos;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace headhuntapi.Controllers
{     [Route("api/[controller]")]
    public class RecruiterController : Controller
    {
        private readonly IRecruiterRepository _recruiterRepo;         private readonly ICompanyRepository _companyRepo;          public RecruiterController(IRecruiterRepository recruiterRepo, ICompanyRepository companyRepo)         {             _recruiterRepo = recruiterRepo;             _companyRepo = companyRepo;         }          [HttpGet]         public JsonResult Get()         {             var recruiters = _recruiterRepo.GetRecruiters();             return Json(recruiters);         }          [HttpGet("{id}")]         public JsonResult Get(Guid id)         {             var recruiter = _recruiterRepo.GetRecruiter(id);             return Json(recruiter);         }          // POST api/values         [HttpPost]         public JsonResult Post([FromBody] RecruiterDto recruiter)         {              var company = _companyRepo.GetCompany(recruiter.CompanyId);             if (company == null)             {                 return Json(false);             }             Recruiters recruiteF = new Recruiters
            {
                Name = recruiter.Name,
                Title = recruiter.Title,                 LinkedIn = recruiter.LinkedIn,                 Email = recruiter.Email,                 Stars = recruiter.Stars,                 Level = recruiter.Level,                 CompanyId = company.Id,                 UniqueId = System.Guid.NewGuid()             };              _recruiterRepo.AddRecruiter(recruiteF);             return Json(true);          }          // DELETE api/values/5         [HttpDelete("{id}")]         public JsonResult Delete(Guid id)         {             _recruiterRepo.DeleteRecruiter(id);             return Json(true);         }
    }
}
