using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FinalMVC.Models
{
    public class Employee
    {
        [Key]
        
        public string EmpID { get; set; }

        public string EmpName { get; set; }

        public string EmpRole { get; set; }
        public string TeamID{ get; set; }

        [ForeignKey("EmpRole")]
        public Login login1 { get; set; }
        [ForeignKey("EmpID")]
        public Login login2 { get; set; }
        [ForeignKey("TeamID")]
        public Team team { get; set; }

        public Employee()
        {

        }
        public Employee(string a, string b, string c,string d)
        {
            EmpID = a;
            EmpName = b;
            EmpRole = c;
            TeamID = d;

        }
    }
}