using System;
namespace headhuntapi.Models.Dtos
{
    public class ReviewDto
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public int Stars { get; set; }
        public int RecruiterId { get; set; }
        public int CompanyId { get; set; }
        public int CandidateId { get; set; }
    }
}
