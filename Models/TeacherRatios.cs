using System;
using System.Collections.Generic;

namespace SeniorProjectWebsite.Models
{
    public partial class TeacherRatios
    {
        public string SurveyYear { get; set; }
        public int? Fipst { get; set; }
        public string PostalStateAbbreviation { get; set; }
        public string StateName { get; set; }
        public string StateEduAgencyName { get; set; }
        public int? Leaid { get; set; }
        public string StLeaid { get; set; }
        public string EduAgencyName { get; set; }
        public int? Schid { get; set; }
        public string StSchid { get; set; }
        public decimal Ncessch { get; set; }
        public string SchName { get; set; }
        public decimal? NumFullTime { get; set; }
    }
}
