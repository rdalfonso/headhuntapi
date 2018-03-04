using System;

namespace headhuntapi.Models.Dtos
{
    public class CandidateDto
    {
        public string Name { get; set; }
        public string Industry { get; set; }
        public string Email { get; set; }
        public int ExperienceYrs { get; set; }
        public string FireBaseId { get; set; }
    }

}
