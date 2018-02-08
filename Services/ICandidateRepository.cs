using System;
using System.Collections.Generic;
using System.Linq;
using headhuntapi.Models;

namespace headhuntapi.Services
{
    public interface ICandidateRepository
    {
        List<Candidates> GetCandidates();
        Candidates GetCandidate(int id);
        bool AddCandidate(Candidates candidate);
        bool DeleteCandidate(int Id);
    }
}
