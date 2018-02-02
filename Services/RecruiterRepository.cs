using System; using System.Collections.Generic; using System.Linq; using headhuntapi.Models; 
namespace headhuntapi.Services
{
    public class RecruiterRepository : IRecruiterRepository
    {
        private readonly HeadHuntReviewContext _context;          public RecruiterRepository(HeadHuntReviewContext context)         {             _context = context;         }          public List<Recruiters> GetRecruiters()         {             List<Recruiters> recruiters = _context.Recruiters.ToList();             return recruiters;         }          public Recruiters GetRecruiter(int id)         {             Recruiters recruiters = _context.Recruiters.Where(r => r.Id == id).FirstOrDefault();             return recruiters;         }          public bool AddRecruiter(Recruiters recruiter)         {             try {                 _context.Recruiters.Add(recruiter);                 _context.SaveChanges();                 return true;             }              catch(System.Exception ex){                 System.Console.WriteLine(ex.ToString());                 return false;             }          }          public bool DeleteRecruiter(int Id)         {             try             {
                Recruiters recruiter = this.GetRecruiter(Id);                  _context.Recruiters.Add(recruiter);                 _context.SaveChanges();                 return true;             }             catch (System.Exception ex)             {                 return false;             }         }
    }
}
