using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using headhuntapi.Models;
using headhuntapi.Services;
using headhuntapi.Models.Dtos;

namespace headhuntapi.Controllers
{
    [Route("api/[controller]")]
    public class AdminController : Controller
    {
        private readonly ICandidateRepository _candidateRepo;
        private readonly ICompanyRepository _companyRepo;
        private readonly IRecruiterRepository _recruiterRepo;
        private readonly IReviewRepository _reviewRepo;

        public AdminController(
            ICandidateRepository candidateRepo,
            ICompanyRepository companyRepo,
            IRecruiterRepository recruiterRepo,
            IReviewRepository reviewRepo)
        {
            _candidateRepo = candidateRepo;
            _companyRepo = companyRepo;
            _recruiterRepo = recruiterRepo;
            _reviewRepo = reviewRepo;
        }

        [HttpGet("{focus}")]
        [Authorize]
        public JsonResult Get(string focus)
        {
            switch(focus) {
                case "Candidate":
                    var candidates = _candidateRepo.GetCandidatesAdmin();
                    return Json(candidates);
                case "Company":
                    var companies = _companyRepo.GetCompaniesAdmin();
                    return Json(companies);
                case "Recruiter":
                    var recruiters = _recruiterRepo.GetRecruitersAdmin();
                    return Json(recruiters);
                case "Review":
                    var reviews = _reviewRepo.GetReviewsAdmin();
                    return Json(reviews);
                default:
                    var reviewsDef = _reviewRepo.GetReviewsAdmin();
                    return Json(reviewsDef);
       
            }
        }
    }
}
