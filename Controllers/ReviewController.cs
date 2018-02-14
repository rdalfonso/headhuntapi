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

        public ReviewController(IReviewRepository reviewRepo)
        {
            _reviewRepo = reviewRepo;
        }

        [HttpGet]
        public JsonResult Get()
        {
            var reviews = _reviewRepo.GetReviews();
            return Json(reviews);
        }

        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            var review = _reviewRepo.GetReview(id);
            return Json(review);
        }

        // POST api/values
        [HttpPost]
        public JsonResult Post([FromBody] ReviewDto review)
        {
            Reviews reviewF = new Reviews
            {
                Title = review.Title,
                Body = review.Body,
                Stars = review.Stars,
                Date = System.DateTime.Now,
                RecruiterId = review.RecruiterId,

                CandidateId = review.CandidateId,
                UniqueId = System.Guid.NewGuid()
            };

            _reviewRepo.AddReview(reviewF);
            return Json(true);

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            _reviewRepo.DeleteReview(id);
            return Json(true);
        }
    }
}
