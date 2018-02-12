using System;
using System.Collections.Generic;

namespace headhuntapi.Models
{
    public partial class Candidates
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Industry { get; set; }
        public string ZipCode { get; set; }
        public int? Stars { get; set; }
    }
}
