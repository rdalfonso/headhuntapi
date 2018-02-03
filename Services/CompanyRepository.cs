using System;
using System.Collections.Generic;
using System.Linq;
using headhuntapi.Models;

namespace headhuntapi.Services
{
    public class CompanyRepository
    {
        private readonly HeadHuntReviewContext _context;

        public CompanyRepository(HeadHuntReviewContext context)
        {
            _context = context;
        }

        public List<Company> GetCompanies()
        {
            List<Company> companies = _context.Company.ToList();
            return companies;
        }

        public Company GetCompany(int id)
        {
            Company companies = _context.Company.Where(r => r.Id == id).FirstOrDefault();
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

        public bool DeleteCompanyr(int Id)
        {
            try
            {
                Company companies = _context.Company.Where(r => r.Id == Id).FirstOrDefault();
                _context.Company.Remove(companies);
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
