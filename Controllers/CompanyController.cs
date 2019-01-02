using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using headhuntapi.Models;
using headhuntapi.Services;
using headhuntapi.Models.Dtos;
using headhuntapi.Filters;

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
        //[Authorize]
        public JsonResult Get()
        {
            var companies = _companyRepo.GetCompanies();
            return Json(companies);
        }

        [HttpGet("{id}")]
        [Authorize]
        public JsonResult Get(Guid id)
        {
            var company = _companyRepo.GetCompany(id);
            return Json(company);
        }

        [HttpPost]
        [Authorize]
        [Throttle(Name = "ThrottleTest", Seconds = 5)]
        public JsonResult Post([FromBody] CompanyDto company)
        {
            Company companyF = new Company
            {
                Name = company.Name,
                Url = company.Url,
                Industry = company.Industry,
                Address1 = company.Address1,
                Address2 = company.Address2,
                City = company.City,
                State = company.State,
                ZipCode = company.ZipCode,
                UniqueId = System.Guid.NewGuid()
            };

            _companyRepo.AddCompany(companyF);
            return Json(true);
        }

        [HttpPut("{id}")]
        [Authorize]
        [Throttle(Name = "ThrottleTest", Seconds = 5)]
        public IActionResult Update(Guid id, [FromBody] CompanyDto company)
        {
            var companyUpdate = _companyRepo.GetCompany(id);
            if (companyUpdate == null)
            {
                return NotFound();
            }
            companyUpdate.Name = company.Name;
            companyUpdate.Url = company.Url;
            companyUpdate.Industry = company.Industry;
            companyUpdate.Address1 = company.Address1;
            companyUpdate.Address2 = company.Address2;
            companyUpdate.City = company.City;
            companyUpdate.State = company.State;
            companyUpdate.ZipCode = company.ZipCode;
            companyUpdate.IsApproved = Convert.ToByte(company.IsApproved);

            _companyRepo.UpdateCompany(companyUpdate);
            return new NoContentResult();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        [Authorize]
        public JsonResult Delete(Guid id)
        {
            _companyRepo.DeleteCompany(id);
            return Json(true);
        }
    }
}
