using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using StudentGrade.Controllers;

namespace StudentGrade.Models
{
    public class SGDbContext:DbContext
    {
        public virtual DbSet<Grade> Grades{get;set;}
        public virtual DbSet<Student>Students{get;set;}
        public SGDbContext(){}
        public SGDbContext(DbContextOptions<SGDbContext> options):base(options){}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("User ID=sa;password=examlyMssql@123; server=localhost;Database=SGDb;trusted_connection=false;Persist Security Info=False;Encrypt=False;");
            }
        }
    }
}