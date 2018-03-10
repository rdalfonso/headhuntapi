using System;
using System.Collections.Generic;

namespace headhuntapi.Models
{
    public partial class Company
    {
        [System.Runtime.Serialization.IgnoreDataMember]
        public int Id { get; set; }
        public Guid? UniqueId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Industry { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public byte IsApproved { get; set; }
        public ICollection<Recruiters> Recruiters { get; set; }
    }
}
