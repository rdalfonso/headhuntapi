using System;
using System.Collections.Generic;
using System.Linq;
using headhuntapi.Models;

namespace headhuntapi.Services
{
    public interface IReviewRepository
    {
        List<Reviews> GetReviews();
        List<Reviews> GetReviewsAdmin();
        Reviews GetReview(Guid id);
        bool AddReview(Reviews recruiter);
        bool UpdateReview(Reviews review);
        bool DeleteReview(Guid Id);
    }
}
