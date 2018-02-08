using System;
using System.Collections.Generic;
using System.Linq;
using headhuntapi.Models;

namespace headhuntapi.Services
{
    public interface IReviewRepository
    {
        List<Reviews> GetReviews();
        Reviews GetReview(int id);
        bool AddReview(Reviews recruiter);
        bool DeleteReview(int Id);
    }
}
