﻿using Entities.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Configuration
{
    public class ContextBase : IdentityDbContext<ApplicationUser>
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options) 
        {
        }
        
        public DbSet<Produto> Produto {  get; set; }
        public DbSet<CompraUsuario> CompraUsuario { get; set; }   
        public DbSet<ApplicationUser> ApplicationUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured) 
            {
                optionsBuilder.UseSqlServer(GetStringConectionConfig());
                base.OnConfiguring(optionsBuilder);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>().ToTable("AspNetUsers").HasKey(t => t.Id);
            
            base.OnModelCreating(builder);
        }

        private string GetStringConectionConfig()
        {
            string srtCon = "Data Source=FARIASTEIN\\SQLSERVER2022;Initial Catalog=DDD_ECOMMERCE;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
            return srtCon;
        }
    }
}
