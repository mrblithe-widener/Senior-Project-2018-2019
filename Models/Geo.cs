using System;
using System.Collections.Generic;

namespace SeniorProjectWebsite.Models
{
    public partial class Geo
    {
        public decimal Ncessch { get; set; }
        public string Name { get; set; }
        public int? Opstfips { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? Zip { get; set; }
        public int? Stfips { get; set; }
        public int? Cfips { get; set; }
        public string CountyName { get; set; }
        public int? Locale { get; set; }
        public decimal? Lat { get; set; }
        public decimal? Lon { get; set; }
        public int? CoreBasedStatisticalArea { get; set; }
        public string NameCbsa { get; set; }
        public int? Cbsatype { get; set; }
        public int? CombinedStatisticalArea { get; set; }
        public string CsaName { get; set; }
        public int? Necta { get; set; }
        public string NectaName { get; set; }
        public int? CongressionalDistrict { get; set; }
        public string SldLower { get; set; }
        public string SldUpper { get; set; }
        public int? Survyear { get; set; }
    }
}
