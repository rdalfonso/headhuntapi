using System;

namespace headhuntapi.Models.Dtos
{
    public class CandidateDto
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public int AdminLevel { get; set; }
        public string FireBaseId { get; set; }
    }

}
