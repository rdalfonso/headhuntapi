using System;
using System.Collections.Generic;
using System.Linq;
using headhuntapi.Models;

namespace headhuntapi.Services
{
    public interface ICompanyRepository
    {
        List<Company> GetCompanies();
        Company GetCompany(int id);
        bool AddCompany(Company company);
        bool DeleteCompany(int Id);
    }
}
