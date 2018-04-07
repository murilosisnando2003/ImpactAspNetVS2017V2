using Loja.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Respositorios.SqlServer.EFCodeFirst
{
    public class LojaDbContext : DbContext
    {
        public LojaDbContext()
        {

        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
