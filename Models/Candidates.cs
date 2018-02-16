using System;
using System.Collections.Generic;

namespace headhuntapi.Models
{
    public partial class Candidates
    {
        public Candidates()
        {
            Reviews = new HashSet<Reviews>();
        }

        public int Id { get; set; }
        public Guid? UniqueId { get; set; }
        public string Name { get; set; }
        public string Industry { get; set; }
        public string Email { get; set; }
        public int? ExperienceYrs { get; set; }

        public ICollection<Reviews> Reviews { get; set; }
    }
}
