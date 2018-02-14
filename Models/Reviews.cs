using System;
using System.Collections.Generic;

namespace headhuntapi.Models
{
    public partial class Reviews
    {
        public int Id { get; set; }
        public Guid UniqueId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int Stars { get; set; }
        public DateTime? Date { get; set; }
        public int? RecruiterId { get; set; }
        public int? CompanyId { get; set; }
        public int? CandidateId { get; set; }
    }
}
