using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using headhuntapi.Models;
using headhuntapi.Services;
using headhuntapi.Models.Dtos;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace headhuntapi.Controllers
{
    [Route("api/[controller]")]
    public class CandidateController : Controller
    {
        private readonly ICandidateRepository _candidateRepo;

        public CandidateController(ICandidateRepository candidateRepo)
        {
            _candidateRepo = candidateRepo;
        }

        [HttpGet]
        public JsonResult Get()
        {
            var candidates = _candidateRepo.GetCandidates();
            return Json(candidates);
        }

        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            var candidate = _candidateRepo.GetCandidate(id);
            return Json(candidate);
        }

        // POST api/values
        [HttpPost]
        public JsonResult Post([FromBody] CandidateDto candidate)
        {
            Candidates candidateF = new Candidates
            {
                Name = candidate.Name,
                Industry = candidate.Industry,
                ZipCode = candidate.ZipCode,
                Stars = candidate.Stars
            };

            _candidateRepo.AddCandidate(candidateF);
            return Json(true);

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            _candidateRepo.DeleteCandidate(id);
            return Json(true);
        }
    }
}
