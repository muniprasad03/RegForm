using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace RegForm.Models
{
    public class RegDbContext : DbContext
    {
        public RegDbContext()
           : base("RegForm")
        {
            
        }

        public DbSet<RegisterModel> registerModels { get; set; }
    }
}
