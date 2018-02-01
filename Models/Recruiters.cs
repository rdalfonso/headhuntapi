using System;
using System.Collections.Generic;

namespace headhuntapi.Models
{
    public partial class Recruiters
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public int Id { get; set; }
        public int? CompanyId { get; set; }
    }
}
