﻿using System; using System.Collections.Generic; using System.Linq; using Microsoft.EntityFrameworkCore; using headhuntapi.Models; 
namespace headhuntapi.Services
{
    public class RecruiterRepository : IRecruiterRepository
    {
        private readonly HeadHuntReviewContext _context;          public RecruiterRepository(HeadHuntReviewContext context)         {             _context = context;         }          public List<Recruiters> GetRecruiters()         {             try {
                List<Recruiters> recruiters =
              _context.Recruiters
                      .Include(r => r.Company)
                      .Include(r => r.Reviews)
                      .ThenInclude(r => r.Candidate)
                      .Where(r => r.IsApproved == 1)
                      .ToList();                 return recruiters;              }              catch(System.Exception ex) {                 string err = ex.ToString();                 return null;             }                      }          public List<Recruiters> GetRecruitersAdmin()         {             List<Recruiters> recruiters =                 _context.Recruiters                         .Include(r => r.Company)                         .Include(r => r.Reviews)                         .ThenInclude(r => r.Candidate)                         .ToList();             return recruiters;         }          public Recruiters GetRecruiter(Guid id)         {             Recruiters recruiters =                  _context.Recruiters                         .Include(r => r.Company)                         .Include(r => r.Reviews)                         .ThenInclude(r => r.Candidate)                         .Where(r => r.UniqueId == id)                         .FirstOrDefault();              return recruiters;         }          public bool AddRecruiter(Recruiters recruiter)         {             try {                 _context.Recruiters.Add(recruiter);                 _context.SaveChanges();                 return true;             }              catch(Exception ex)             {                 Console.WriteLine(ex.ToString());                 return false;             }         }          public bool UpdateRecruiter(Recruiters recruiter)         {             try             {                 _context.Recruiters.Update(recruiter);                 _context.SaveChanges();                 return true;             }             catch (Exception ex)             {                 Console.WriteLine(ex.ToString());                 return false;             }         }          public bool DeleteRecruiter(Guid Id)         {             try             {
                Recruiters recruiter = _context.Recruiters.Where(r => r.UniqueId == Id).FirstOrDefault();                 _context.Recruiters.Remove(recruiter);                 _context.SaveChanges();                 return true;             }             catch (Exception ex)             {                 Console.WriteLine(ex.ToString());                 return false;             }         }
    }
}
