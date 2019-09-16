using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ACT_Youth_Homelessness_Services_Directory.Models
{
    public class ServicesClass
    {
        /*Service details*/
        public int ID { get; set; }
        public string ServiceName { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string GeoTag { get; set; }
        public string Email { get; set; }
        public string OpeningHours { get; set; }
        /*category types*/
        public bool Shelter { get; set; }
        public bool Food { get; set; }
        public bool JobsEmployment { get; set; }
        public bool FamilyCommunity { get; set; }
        public bool LegalFinancial { get; set; }
        public bool DiversityInclusion { get; set; }
        public bool HealthWellbeing { get; set; }
        /*service locations*/
        public bool Belconnen { get; set; }
        public bool Gungahlin { get; set; }
        public bool Woden { get; set; }
        public bool Tuggeranong { get; set; }
        public bool Civic { get; set; }
        /*special access notes*/
        public string DisabledAccess { get; set; }
        public string WhoCanAccess { get; set;}
        public string ReferralRequired { get; set; }
        public string AgeRange { get; set; }
        public string Cost { get; set; }
        public string Lnaguages { get; set; }

    }
}