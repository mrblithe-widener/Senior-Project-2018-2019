using System;
using System.Collections.Generic;

namespace SeniorProjectWebsite.Models
{
    public partial class Business
    {
        public string GeoId { get; set; }
        public int? GeoId2 { get; set; }
        public int? NaicsId { get; set; }
        public string NaicsMeaning { get; set; }
        public decimal ZipCode { get; set; }
        public string Location { get; set; }
        public int? Year { get; set; }
        public int? NumEstablishments { get; set; }
        public string NumPaidEmployees { get; set; }
        public string FirstQuarterPayroll { get; set; }
        public string AnnualPayroll { get; set; }
    }
}
