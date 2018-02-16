using System;
using System.Collections.Generic;

namespace headhuntapi.Models
{
    public partial class Reviews
    {
        [System.Runtime.Serialization.IgnoreDataMember]
        public int Id { get; set; }
        public Guid? UniqueId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int? Stars { get; set; }
        public DateTime? Date { get; set; }

        [System.Runtime.Serialization.IgnoreDataMember]
        public int? RecruiterId { get; set; }
        [System.Runtime.Serialization.IgnoreDataMember]
        public int? CandidateId { get; set; }

        [System.Runtime.Serialization.IgnoreDataMember]
        public Candidates Candidate { get; set; }
        [System.Runtime.Serialization.IgnoreDataMember]
        public Recruiters Recruiter { get; set; }
    }
}
