using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using headhuntapi.Models;

namespace headhuntapi.Services
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly HeadHuntReviewContext _context;

        public ReviewRepository(HeadHuntReviewContext context)
        {
            _context = context;
        }

        public List<Reviews> GetReviews()
        {
            List<Reviews> reviews = 
                _context.Reviews
                        .Include(r => r.Recruiter)
                        .Include(r => r.Candidate)
                        .Where(r => r.IsApproved == 1)
                        .ToList();
            return reviews;
        }

        public List<Reviews> GetReviewsAdmin()
        {
            List<Reviews> reviews =
                _context.Reviews
                        .Include(r => r.Recruiter)
                        .Include(r => r.Candidate)
                        .ToList();
            return reviews;
        }

        public Reviews GetReview(Guid id)
        {
            Reviews reviews =
                _context.Reviews
                        .Include(r => r.Recruiter)
                        .Include(r => r.Candidate)
                        .Where(r => r.UniqueId == id)
                        .FirstOrDefault();
            return reviews;
        }

        public bool AddReview(Reviews reviews)
        {
            try
            {
                _context.Reviews.Add(reviews);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool UpdateReview(Reviews reviews)
        {
            try
            {
                _context.Reviews.Update(reviews);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool DeleteReview(Guid Id)
        {
            try
            {
                Reviews reviews = _context.Reviews.Where(r => r.UniqueId == Id).FirstOrDefault();
                _context.Reviews.Remove(reviews);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
