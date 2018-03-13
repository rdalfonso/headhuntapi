using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using headhuntapi.Services;

namespace headhuntapi.Controllers
{
    [Route("api/[controller]")]
    public class SearchController : Controller
    {
        private readonly ICompanyRepository _companyRepo;

        public SearchController(ICompanyRepository companyRepo)
        {
            _companyRepo = companyRepo;
        }

        [HttpGet("{term}")]
        [Authorize]
        public JsonResult Get(string term)
        {
            var companies = _companyRepo.GetCompaniesSearch(term);
            return Json(companies);
        }




    }
}
