﻿using System;
using System.Collections.Generic;
using System.Linq;
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
            List<Reviews> reviews = _context.Reviews.ToList();
            return reviews;
        }

        public Reviews GetReview(int id)
        {
            Reviews reviews = _context.Reviews.Where(r => r.Id == id).FirstOrDefault();
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

        public bool DeleteReview(int Id)
        {
            try
            {
                Reviews reviews = _context.Reviews.Where(r => r.Id == Id).FirstOrDefault();
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
