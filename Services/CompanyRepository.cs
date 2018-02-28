using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using headhuntapi.Models;

namespace headhuntapi.Services
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly HeadHuntReviewContext _context;

        public CompanyRepository(HeadHuntReviewContext context)
        {
            _context = context;
        }

        public List<Company> GetCompanies()
        {
            List<Company> companies = 
                _context.Company
                        .Include(r => r.Recruiters)
                        .OrderBy(c => c.Name)
                        .ToList();
            return companies;
        }


        public List<Company> GetCompaniesSearch(string term)
        {
            List<Company> companies =
                _context.Company.Where(c => c.Name.StartsWith(term, StringComparison.InvariantCultureIgnoreCase))
                 .ToList();

            return companies;
        }


        public Company GetCompany(Guid id)
        {
            Company companies = 
                _context.Company
                        .Include(r => r.Recruiters)
                        .Where(r => r.UniqueId == id)
                        .FirstOrDefault();
            return companies;
        }

        public bool AddCompany(Company companies)
        {
            try
            {
                _context.Company.Add(companies);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }

        }

        public bool DeleteCompany(Guid Id)
        {
            try
            {
                Company companies = _context.Company.Where(r => r.UniqueId == Id).FirstOrDefault();
                _context.Company.Remove(companies);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
