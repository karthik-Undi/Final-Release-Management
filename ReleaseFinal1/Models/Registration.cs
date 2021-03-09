using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReleaseFinal1.Models
{
    public class Registration
    {
        [Key]
        [Required(ErrorMessage ="Please enter the Employee ID")]
        public string EmpID { get; set; }

        [Required(ErrorMessage = "Please enter the Employee Name")]
        public string EmpName { get; set; }

        [Required(ErrorMessage = "Please select your Role")]
        public string EmpRole { get; set; }

        [Required(ErrorMessage = "Please enter the Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter the Password")]
        [Compare("Password",ErrorMessage ="Passwords do not match")]
        public string ConfirmPassword { get; set; }
    }
}