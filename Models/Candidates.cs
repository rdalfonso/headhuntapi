using System;
using System.Collections.Generic;

namespace headhuntapi.Models
{
    public partial class Candidates
    {
        [System.Runtime.Serialization.IgnoreDataMember]
        public int Id { get; set; }
        public Guid? UniqueId { get; set; }
        public string Name { get; set; }
        public string Industry { get; set; }
        public string Email { get; set; }
        public int? ExperienceYrs { get; set; }
        [System.Runtime.Serialization.IgnoreDataMember]
        public string FireBaseId { get; set; }

        [System.Runtime.Serialization.IgnoreDataMember]
        public ICollection<Reviews> Reviews { get; set; }
    }
}
