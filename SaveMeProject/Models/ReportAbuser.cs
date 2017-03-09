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
        public string Other { get; set; }

        [Display(Name ="Enter type and number of animal(s)")]
        [Placeholder("Ex. 3 cats, 2 dogs")]
        public string AbuseDetails { get; set; }

        [Required]
        [Display(Name ="Describe the property")]
        public string PropertyDescription { get; set; }
        [Display(Name ="Describe the abuser(s)")]
        public string AbuserDescription { get; set; }
        [Display(Name ="Name of abuser")]
        public string OwnerName { get; set; }

        [Display(Name ="Your name")]
        public string FullName { get; set; }
        [DataType(DataType.EmailAddress)]
        [Display(Name ="Email address")]
        public string ReportEmail { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name ="Phone number")]
        public string ReportPhone { get; set; }
        [Display(Name ="May we contact you for more information?")]
        public bool Contact { get; set; }
        [Display(Name ="Would you like to receive report updates?")]
        public bool Updates { get; set; }


    }
}