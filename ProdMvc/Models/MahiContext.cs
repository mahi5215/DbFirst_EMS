using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
namespace ProdMvc.Models;
public class MahiContext:DbContext
{
    public virtual DbSet<Product> Product{get; set;}
    public MahiContext(){}
    public MahiContext(DbContextOptions<MahiContext> options):base(options)
    {

    }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("User ID=sa;password=examlyMssql@123; server=localhost;Database=Mahi;trusted_connection=false;Persist Security Info=False;Encrypt=False;");
            }
        }
    

}