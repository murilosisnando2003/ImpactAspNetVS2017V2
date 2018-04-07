using Microsoft.VisualStudio.TestTools.UnitTesting;
using Loja.Respositorios.SqlServer.EFCodeFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja.Dominio;

namespace Loja.Respositorios.SqlServer.EFCodeFirst.Tests
{
    [TestClass()]
    public class LojaDbContextTests
    {
        LojaDbContext _db = new LojaDbContext();

        [TestMethod()]
        public void LojaDbContextTest()
        {
            var categoria = new Categoria();
            categoria.Nome = "Papelaria";

            _db.Categorias.Add(categoria);

            _db.SaveChanges();
        }
    }
}