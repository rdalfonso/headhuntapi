using System;
namespace headhuntapi.Models.Dtos
{
    public class Review
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public int Stars { get; set; }
        public DateTime Date { get; set; }
        public int RecruiterId { get; set; }
        public int CandidateId { get; set; }
    }
}
