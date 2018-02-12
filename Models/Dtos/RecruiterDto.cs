using System;
namespace headhuntapi.Models.Dtos
{
    public class RecruiterDto
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string ZipCode { get; set; }
        public int Stars { get; set; }
        public string Level { get; set; }
        public int CompanyId { get; set; }
    }
}
