using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FinalMVC.Models
{
    public class ReleaseManagementFinalContext:DbContext
    {
        public ReleaseManagementFinalContext() : base("FINALRELEASE")
        {

        }
        public DbSet<EmployeeTeamAssignment> EmployeeTeamAssignmentList { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Tester> Testers { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<Bug> Bugs { get; set; }
    }
}
