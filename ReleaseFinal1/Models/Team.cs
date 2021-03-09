using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalMVC.Models
{
    public class Team
    {

        [Key]
        [Required(ErrorMessage = "Please Enter the teamID")]
        [RegularExpression("[T][0-9]*")]
        public string TeamID { get; set; }

        [Required(ErrorMessage = "Please select the teamID")]
        public string TeamLeadID { get; set; }

        public string IsAvailable { get; set; }
        [ForeignKey("TeamLeadID")]
        public Employee employee { get; set; }
    }
}