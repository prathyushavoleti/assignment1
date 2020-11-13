using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace studentEntity.Models
{
    public class StudentContext:DbContext
    {
        public StudentContext() : base("StudentConnection")
        {

        }
        public DbSet<student> StudentTable { get; set; }
    }
}