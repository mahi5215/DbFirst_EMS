using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


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