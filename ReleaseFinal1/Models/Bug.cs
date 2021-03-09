using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalMVC.Models
{
        public class Bug
        {
            [Key]
            [Required(ErrorMessage ="BugID should not be empty")]
            [RegularExpression("[B][0-9]*")]
            public string BugID { get; set; }

        [Required(ErrorMessage = "Please select the module ID")]
        public string ModuleID { get; set; }
            [ForeignKey("ModuleID")]
            public Module module { get; set; }

        [Required(ErrorMessage = "Please select the tester ID")]
        public string TesterID { get; set; }
            [ForeignKey("TesterID")]
            public Tester tester { get; set; }

        [Required(ErrorMessage = "Bug Status should not be empty")]
        public string BugStatus { get; set; }

        public string BugDescription { get; set; }
        public Bug(string id, string mid, string tid, string bs,string bd)
            {
                this.BugID = id;
                this.ModuleID = mid;
                TesterID = tid;
                BugStatus = bs;
            BugDescription = bd;
            }
            public Bug()
            {

            }
        }
    }