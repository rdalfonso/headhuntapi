﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
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
            List<Candidates> candidates =
                _context.Candidates
                        .Include(r => r.Reviews)
                        .ToList();

            return candidates;
        }

        public List<Candidates> GetCandidatesAdmin()
        {
            List<Candidates> candidates =
                _context.Candidates
                        .Include(r => r.Reviews)
                        .ToList();

            return candidates;
        }

        public Candidates GetCandidate(Guid id)
        {
            Candidates candidates = 
                _context.Candidates
                        .Include(r => r.Reviews)
                        .Where(r => r.UniqueId == id)
                        .FirstOrDefault();
            return candidates;
        }

        public Candidates GetCandidateForAuth(string id)
        {
            Candidates candidates = _context.Candidates.Where(r => r.FireBaseId == id).FirstOrDefault();
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


        public bool UpdateCandidate(Candidates candidates)
        {
            try
            {
                _context.Candidates.Update(candidates);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }


        public bool DeleteCandidate(Guid Id)
        {
            try
            {
                Candidates candidates = _context.Candidates.Where(r => r.UniqueId == Id).FirstOrDefault();
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
