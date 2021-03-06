﻿using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using headhuntapi.Models;
using headhuntapi.Services;
using headhuntapi.Models.Dtos;
using headhuntapi.Filters;

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
        //[Authorize]
        public JsonResult Get()
        {
            var candidates = _candidateRepo.GetCandidates();
            return Json(candidates);
        }

        [HttpGet("{id}")]
        public JsonResult Get(Guid id)
        {
            var candidate = _candidateRepo.GetCandidate(id);
            return Json(candidate);
        }

        // POST api/values
        [HttpPost]
        [Authorize]
        [Throttle(Name = "ThrottleTest", Seconds = 5)]
        public JsonResult Post([FromBody] CandidateDto candidate)
        {
            Candidates candidateF = new Candidates
            {
                Name = candidate.Name,
                Title = candidate.Title,
                Email = candidate.Email,
                AdminLevel = candidate.AdminLevel,
                FireBaseId = candidate.FireBaseId,
                UniqueId = System.Guid.NewGuid()
            };

            _candidateRepo.AddCandidate(candidateF);
            return Json(true);
        }

        [HttpPut("{id}")]
        [Authorize]
        [Throttle(Name = "ThrottleTest", Seconds = 5)]
        public IActionResult Update(Guid id, [FromBody] CandidateDto candidate)
        {
            var candidateUpdate = _candidateRepo.GetCandidateForAuth(candidate.FireBaseId);
            if (candidateUpdate == null)
            {
                return NotFound();
            }
            candidateUpdate.Name = candidate.Name;
            candidateUpdate.Email = candidate.Email;
            candidateUpdate.Title = candidate.Title;

            _candidateRepo.UpdateCandidate(candidateUpdate);
            return new NoContentResult();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        [Authorize]
        public JsonResult Delete(Guid id)
        {
            _candidateRepo.DeleteCandidate(id);
            return Json(true);
        }
    }
}
