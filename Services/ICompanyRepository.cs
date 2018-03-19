using System;
using System.Collections.Generic;
using System.Linq;
using headhuntapi.Models;

namespace headhuntapi.Services
{
    public interface ICompanyRepository
    {
        List<Company> GetCompaniesSearch(string text);
        List<Company> GetCompanies();
        List<Company> GetCompaniesAdmin();
        Company GetCompany(Guid id);
        bool AddCompany(Company company);
        bool UpdateCompany(Company company);
        bool DeleteCompany(Guid Id);
    }
}
