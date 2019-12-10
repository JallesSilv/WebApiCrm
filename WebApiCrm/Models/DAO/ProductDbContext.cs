﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using WebApiCrm.Models.Auxiliar;
using WebApiCrm.Models.Entidades;

namespace WebApiCrm.Models.DAO
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions options) : 
            base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            
        }
                
        public DbSet<Cliente> Cliente { get; set; }

    }
}
