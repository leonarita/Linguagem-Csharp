using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _68_RecursosHumanos.Models
{
    public class RhContexto : DbContext
    {
        public RhContexto() : base("name=RhContexto") {   }

        public DbSet<Funcionario> Funcionario { get; set; } 
    }
}