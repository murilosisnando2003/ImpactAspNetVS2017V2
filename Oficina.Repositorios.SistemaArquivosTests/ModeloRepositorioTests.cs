using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class ModeloRepositorioTests
    {
        ModeloRepositorio _marcaRepositorio = new ModeloRepositorio();

        [TestMethod()]
        [DataRow(1)]
        [DataRow(1)]
        [DataRow(1)]
        public void SelecionarPorMarcaTest(int marcaId)
        {
            var modelos = _marcaRepositorio.SelecionarPorMarca(marcaId);

            Assert.IsTrue(modelos.Count != 0);
        }
    }
}