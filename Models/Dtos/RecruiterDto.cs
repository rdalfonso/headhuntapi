﻿using System;
namespace headhuntapi.Models.Dtos
{
    public class RecruiterDto
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string LinkedIn { get; set; }
        public string Email { get; set; }
        public string Level { get; set; }
        public Guid CompanyId { get; set; }
        public bool IsApproved { get; set; }
    }
}
