using System; using System.Collections.Generic; using System.Linq; using headhuntapi.Models; 
namespace headhuntapi.Services
{
    public interface IRecruiterRepository
    {
        List<Recruiters> GetRecruiters();         Recruiters GetRecruiter(Guid id);         bool AddRecruiter(Recruiters recruiter);         bool UpdateRecruiter(Recruiters recruiter);         bool DeleteRecruiter(Guid Id);
    }
}
