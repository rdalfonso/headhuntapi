using System; using System.Collections.Generic; using System.Linq; using headhuntapi.Models; 
namespace headhuntapi.Services
{
    public class RecruiterRepository : IRecruiterRepository
    {
        private readonly HeadHuntReviewContext _context;          public RecruiterRepository(HeadHuntReviewContext context)         {             _context = context;         }          public List<Recruiters> GetRecruiters()         {             List<Recruiters> recruiters = _context.Recruiters.ToList();             return recruiters;         }          public Recruiters GetRecruiter(int id)         {             Recruiters recruiters = _context.Recruiters.Where(r => r.Id == id).FirstOrDefault();             return recruiters;         }          public string AddRecruiter(Recruiters recruiter)         {             return "true";         }          public string DeleteRecruiter(string Id)         {             return "Hello DeleteRecruiter";         }
    }
}
