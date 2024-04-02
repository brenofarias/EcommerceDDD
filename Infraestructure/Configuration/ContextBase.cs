using Entities.Entities;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured) 
            {
                optionsBuilder.UseSqlServer(GetStringConectionConfig());
                base.OnConfiguring(optionsBuilder);
            }
        }

        private string GetStringConectionConfig()
        {
            string srtCon = "Integrated Security=SSPI;TrustServerCertificate=True;Persist Security Info=False;User ID=breno;Initial Catalog=DDD_ECOMMERCE;Data Source=FARIASTEIN\\SQLSERVER2022";
            return srtCon;
        }
    }
}
