﻿using Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Entities
{
    public class Internship
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string SpreadSheetId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Requirements { get; set; }

        public int MaxCandidateCount { get; set; }

        public DateTime RegistrationStartDate { get; set; }

        public DateTime RegistrationFinishDate { get; set; }

        public ICollection<InternshipLanguage> LanguageTypes { get; set; }

        public ICollection<Candidate> Candidates { get; set; }

        public ICollection<InternshipStack> InternshipStacks { get; set; }

        public ICollection<User> Users { get; set; }

        public ICollection<Team> Teams { get; set; }

        public ICollection<Country> Countries { get; set; }

        public InternshipStatusType InternshipStatusType { get; set; }

        public string ImageLink { get; set; }
    }
}
