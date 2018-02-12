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
    public class CompanyController : Controller
    {
        private readonly ICompanyRepository _companyRepo;

        public CompanyController(ICompanyRepository companyRepo)
        {
            _companyRepo = companyRepo;
        }

        [HttpGet]
        public JsonResult Get()
        {
            var companies = _companyRepo.GetCompanies();
            return Json(companies);
        }

        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            var company = _companyRepo.GetCompany(id);
            return Json(company);
        }

        // POST api/values
        [HttpPost]
        public JsonResult Post([FromBody] CompanyDto company)
        {
            Company companyF = new Company
            {
                Name = company.Name,
                Industry = company.Industry,
                Location = company.Location,
                Stars = company.Stars
            };

            _companyRepo.AddCompany(companyF);
            return Json(true);

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            _companyRepo.DeleteCompany(id);
            return Json(true);
        }
    }
}
