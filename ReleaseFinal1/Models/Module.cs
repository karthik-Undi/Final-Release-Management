using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalMVC.Models
{
    public class Module
    {
        [Key]
        [Required(ErrorMessage = "Please Enter the Module ID")]
        public string ModuleID { get; set; }

        [Required(ErrorMessage = "Please Enter the Module Name")]
        public string ModuleName { get; set; }

        [Required(ErrorMessage = "Please select the Project ID")]
        public string ProjectID { get; set; }
        [ForeignKey("ProjectID")]
        public Project project { get; set; }

        [Required(ErrorMessage = "Please select the Module Status")]
        public string ModuleStatus { get; set; }

        [Required(ErrorMessage = "Please select the DeveloperID")]
        public string DeveloperID { get; set; }

        [ForeignKey("DeveloperID")]
        public Developer developer { get; set; }

        [Required(ErrorMessage = "Please select the TesterID")]
        public string TesterID { get; set; }

        [ForeignKey("TesterID")]
        public Tester tester { get; set; }
        public Module(string a, string b, string c, string d, string e, string f)
        {
            ModuleID = a;
            ModuleName = b;
            ProjectID = c;
            DeveloperID = d;
            TesterID = e;
            ModuleStatus = f;


        }
        public Module()
        {

        }
    }
}