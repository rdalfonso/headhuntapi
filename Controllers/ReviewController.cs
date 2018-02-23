using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using headhuntapi.Models;
using headhuntapi.Services;
using headhuntapi.Models.Dtos;

namespace headhuntapi.Controllers
{
    [Route("api/[controller]")]
    public class ReviewController : Controller
    {
        private readonly IReviewRepository _reviewRepo;
        private readonly IRecruiterRepository _recruiterRepo;

        public ReviewController(IReviewRepository reviewRepo, IRecruiterRepository recruiterRepo)
        {
            _reviewRepo = reviewRepo;
            _recruiterRepo = recruiterRepo;
        }

        [HttpGet]
        public JsonResult Get()
        {
            var reviews = _reviewRepo.GetReviews();
            return Json(reviews);
        }

        [HttpGet("{id}")]
        public JsonResult Get(Guid id)
        {
            var review = _reviewRepo.GetReview(id);
            return Json(review);
        }

        // POST api/values
        [HttpPost]
        public JsonResult Post([FromBody] ReviewDto review)
        {
            var recruiter = _recruiterRepo.GetRecruiter(review.RecruiterId);
            if(recruiter == null) {
                return Json(false);
            }
            Reviews reviewF = new Reviews
            {
                Title = review.Title,
                Body = review.Body,
                Stars = review.Stars,
                Date = System.DateTime.Now,
                RecruiterId = recruiter.Id,
                UniqueId = System.Guid.NewGuid()
            };

            _reviewRepo.AddReview(reviewF);
            return Json(true);

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public JsonResult Delete(Guid id)
        {
            _reviewRepo.DeleteReview(id);
            return Json(true);
        }
    }
}
