using System;
using System.Collections.Generic;

namespace SeniorProjectWebsite.Models
{
    public partial class Index
    {
        public string Name { get; set; }
        public decimal? Zip { get; set; }
        public string State { get; set; }
        public string CountyName { get; set; }
        public decimal? Leaid { get; set; }
        public long Nceesch { get; set; }
    }
}
