using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using headhuntapi.Models;
using headhuntapi.Services;
using headhuntapi.Models.Dtos;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
        public JsonResult Get(string term)
        {
            var companies = _companyRepo.GetCompaniesSearch(term);
            return Json(companies);
        }




    }
}
