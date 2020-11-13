using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace employeeMVC.Models
{
    public class employeecontext:DbContext
    {
        public employeecontext() : base("EmployeeConnectionString")
        {

        }
        public DbSet<employee> EmployeeTable { get; set; }
    }
}