using System;
namespace headhuntapi.Models.Dtos
{
    public class RecruiterDto
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public string Title { get; set; }
        public string LinkedIn { get; set; }
        public string Email { get; set; }
        public int Stars { get; set; }
        public string Level { get; set; }
        public int CompanyId { get; set; }
    }
}
