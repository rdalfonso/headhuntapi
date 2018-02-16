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
                        .ToList();
            return companies;
        }

        public Company GetCompany(int id)
        {
            Company companies = 
                _context.Company
                        .Include(r => r.Recruiters)
                        .Where(r => r.Id == id)
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

        public bool DeleteCompany(int Id)
        {
            try
            {
                Company companies = _context.Company.Where(r => r.Id == Id).FirstOrDefault();
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
