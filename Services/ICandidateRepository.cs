using System;
using System.Collections.Generic;
using System.Linq;
using headhuntapi.Models;

namespace headhuntapi.Services
{
    public interface ICandidateRepository
    {
        List<Candidates> GetCandidates();
        Candidates GetCandidate(Guid id);
        Candidates GetCandidateForAuth(string id);
        bool AddCandidate(Candidates candidate);
        bool UpdateCandidate(Candidates candidate);
        bool DeleteCandidate(Guid Id);
    }
}
