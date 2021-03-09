using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalMVC.Models
{
    public class Project
    {
        [Key]
        [Required(ErrorMessage ="Please enter the Project ID")]
        public string ProjectID { get; set; }

        [Required(ErrorMessage = "Please enter the Project name")]
        public string ProjectName { get; set; }

        [Required(ErrorMessage = "Please select the Start date of a project")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Please select the Expected End date of a project")]
        public DateTime ExpectedEndDate { get; set; }

        [Required(ErrorMessage = "Please select the Actual End date of a project")]
        public DateTime ActualEndDate { get; set; }

        [Required(ErrorMessage = "Please select the TeamID")]
        public string TeamID { get; set; }
        [ForeignKey("TeamID")]
        public Team team { get; set; }

        [Required(ErrorMessage = "Please select the Project Status")]
        public string ProjectStatus { get; set; }

        public Project(string id, string nam, DateTime sd, DateTime eed, DateTime aed, string tid, string ps)
        {
            ProjectID = id;
            ProjectName = nam;
            StartDate = sd;
            ExpectedEndDate = eed;
            ActualEndDate = aed;
            ProjectStatus = ps;

        }
        public Project()
        {

        }
    }
}