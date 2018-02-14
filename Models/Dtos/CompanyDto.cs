using System;
namespace headhuntapi.Models.Dtos
{
    public class CompanyDto
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Industry { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }
}
