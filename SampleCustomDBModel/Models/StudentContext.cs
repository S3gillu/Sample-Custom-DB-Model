using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SampleCustomDBModel.Models
{
   
        public class StudentContext : DbContext
        {
            public StudentContext()
                : base("StudentDbContext")
            {
            }
            public DbSet<Student> Students { get; set; }
        }

    
}