using System;
namespace headhuntapi.Models.Dtos
{
    public class ReviewDto
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public int Stars { get; set; }
        public Guid RecruiterId { get; set; }
        public string CandidateFbId { get; set; }
        public int IsTooAggressive { get; set; }
        public int IsDishonestJob { get; set; }
        public int IsPersonalInfo { get; set; }
        public int IsFakeProfile { get; set; }
        public bool IsApproved { get; set; }
    }
}
