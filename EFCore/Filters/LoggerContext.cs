using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EFCore.Domain.Core.FiltersInfo;
using Microsoft.EntityFrameworkCore;
namespace EFCore.Filters
{
    public class LoggerContext : DbContext
    {
        
        public DbSet<ExceptionDetails> Exceptions { get; set; }

        public LoggerContext() 
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=StudentContext;Trusted_Connection=True;");
        }
        
    }
}