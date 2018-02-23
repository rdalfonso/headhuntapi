using System;
namespace headhuntapi.Models.Dtos
{
    public class ReviewDto
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public int Stars { get; set; }
        public Guid RecruiterId { get; set; }
    }
}
