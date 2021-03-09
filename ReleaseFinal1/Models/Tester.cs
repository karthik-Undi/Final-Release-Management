using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalMVC.Models
{
    public class Tester
    {

        [Key]
        public string TesterID { get; set; }


        public string TesterName { get; set; }

        public string TesterStatus { get; set; }

       
    }
}