using System;
using System.Collections.Generic;

namespace headhuntapi.Models
{
    public partial class Recruiters
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string ZipCode { get; set; }
        public int Stars { get; set; }
        public string Level { get; set; }
        public int Id { get; set; }
        public int? CompanyId { get; set; }
    }
}
