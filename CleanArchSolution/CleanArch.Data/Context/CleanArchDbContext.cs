using CleanArch.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Data.Context
{
    public class CleanArchDbContext:DbContext
    {
        public CleanArchDbContext(DbContextOptions options) : base(options)
        { 
        
        }

        public DbSet<Course> Courses { get; set; }
    }
}
