using System;
using System.Collections.Generic;

namespace headhuntapi.Models
{
    public partial class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Industry { get; set; }
        public string Location { get; set; }
        public int Stars { get; set; }
    }
}
