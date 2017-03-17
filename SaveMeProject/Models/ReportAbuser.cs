using FormFactory.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SaveMeProject.Models
{
    public class ReportAbuser
    {
        [Key]
        public int ReportID { get; set; }

        [Required]
        public string Topic { get; set; }
        public DateTime Date { get; set; }

        //Lat and long added for google map api
        public string Latitude { get; set; }
        public string Longitude { get; set; }


        [Display(Name ="No food")]
        public bool Food { get; set; }
        [Display(Name = "No shelter")]
        public bool Shelter { get; set; }
        public bool Abandoned { get; set; }
        public bool Poisoned { get; set; }
        public bool Underweight { get; set; }
        public bool Trapping { get; set; }
        [Display(Name ="No water")]
        public bool Water { get; set; }
        public bool Shot { get; set; }
        public bool Injury { get; set; }
        public bool Abuse { get; set; }
        [DataType(DataType.MultilineText)]
        public string Other { get; set; }


        [Display(Name ="Enter type and number of animal(s)")]
        [Placeholder("Ex. 3 cats, 2 dogs")]
        [DataType(DataType.MultilineText)]
        public string AbuseDetails { get; set; }

        [Required]
        [Display(Name ="Describe the property")]
        [DataType(DataType.MultilineText)]
        public string PropertyDescription { get; set; }
        [Display(Name ="Describe the abuser(s)")]
        [DataType(DataType.MultilineText)]
        public string AbuserDescription { get; set; }
        [Display(Name ="Name of abuser(s)")]
        [DataType(DataType.MultilineText)]
        public string OwnerName { get; set; }

        [Display(Name ="Name")]
        public string FullName { get; set; }
        [Display(Name ="Email address")]
        [DataType(DataType.EmailAddress)]
        public string ReportEmail { get; set; }
        [Display(Name ="Phone number")]
        [DataType(DataType.PhoneNumber)]
        public string ReportPhone { get; set; }
        [Display(Name ="May we contact you for more information?")]
        public bool Contact { get; set; }
        [Display(Name ="Would you like to receive report updates?")]
        public bool Updates { get; set; }


    }
}