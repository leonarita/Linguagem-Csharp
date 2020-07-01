using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder op)
        {
            op.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ForumDB;Integrated Security=True");
        }

        public virtual void SetModified (object entity)
        {
            Entry(entity).State = EntityState.Modified; 
        }
    }
}
