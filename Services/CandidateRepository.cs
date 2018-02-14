﻿using System;
using System.Collections.Generic;
using System.Linq;
using headhuntapi.Models;

namespace headhuntapi.Services
{
    public class CandidateRepository : ICandidateRepository
    {
        private readonly HeadHuntReviewContext _context;

        public CandidateRepository(HeadHuntReviewContext context)
        {
            _context = context;
        }

        public List<Candidates> GetCandidates()
        {
            List<Candidates> candidates = _context.Candidates.ToList();
            return candidates;
        }

        public Candidates GetCandidate(int id)
        {
            Candidates candidates = _context.Candidates.Where(r => r.Id == id).FirstOrDefault();
            return candidates;
        }

        public bool AddCandidate(Candidates candidates)
        {
            try
            {
                _context.Candidates.Add(candidates);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }

        }

        public bool DeleteCandidate(int Id)
        {
            try
            {
                Candidates candidates = _context.Candidates.Where(r => r.Id == Id).FirstOrDefault();
                _context.Candidates.Remove(candidates);
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