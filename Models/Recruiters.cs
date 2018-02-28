using System;
using System.Collections.Generic;

namespace headhuntapi.Models
{
    public partial class Recruiters
    {
        public Recruiters()
        {
            Reviews = new HashSet<Reviews>();
        }

        public int Id { get; set; }
        public Guid? UniqueId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string LinkedIn { get; set; }
        public string Email { get; set; }
        public int? Stars { get; set; }
        public string Level { get; set; }
        public int? CompanyId { get; set; }

        public Company Company { get; set; }
        public ICollection<Reviews> Reviews { get; set; }
    }
}
