using System; using System.Collections.Generic; using System.Linq; using System.Threading.Tasks; using Microsoft.AspNetCore.Mvc; using headhuntapi.Models; using headhuntapi.Services; using headhuntapi.Models.Dtos;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace headhuntapi.Controllers
{     [Route("api/[controller]")]
    public class RecruiterController : Controller
    {
        private readonly IRecruiterRepository _recruiterRepo;          public RecruiterController(IRecruiterRepository recruiterRepo)         {             _recruiterRepo = recruiterRepo;         }          [HttpGet]         public JsonResult Get()         {             var recruiters = _recruiterRepo.GetRecruiters();             return Json(recruiters);         }          [HttpGet("{id}")]         public JsonResult Get(int id)         {             var recruiter = _recruiterRepo.GetRecruiter(id);             return Json(recruiter);         }          // POST api/values         [HttpPost]         public JsonResult Post(Recruiter recruiter)         {             Recruiters recruiterEF = new Recruiters();             recruiterEF.Name = recruiter.Name;             recruiterEF.Company = recruiter.Company;             recruiterEF.CompanyId = recruiter.CompanyId;             _recruiterRepo.AddRecruiter(recruiterEF);             return Json(true);          }          // DELETE api/values/5         [HttpDelete("{id}")]         public void Delete(int id)         {         }
    }
}
