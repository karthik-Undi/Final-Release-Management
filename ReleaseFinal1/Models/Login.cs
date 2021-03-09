using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalMVC.Models
{
    public class Login
    {
        [Key]
        
        public string LoginID { get; set; }
        public string Password { get; set; }

        public string EmpRole { get; set; }

        public Login(string a, string b,string c)
        {
            LoginID = a;
            Password = b;
            EmpRole = c;
        }
        public Login()
        {

        }
    }
}