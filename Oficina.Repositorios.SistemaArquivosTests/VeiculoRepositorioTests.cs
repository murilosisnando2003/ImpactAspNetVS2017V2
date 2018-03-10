﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Dominio;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class VeiculoRepositorioTests
    {
        [TestMethod()]
        
        public void InserirTest()
        {
            var repositorio = new VeiculoRepositorio();
            var veiculo = new Veiculo();
            veiculo.Ano = 2014;
            veiculo.Cambio = Cambio.Manual;
            veiculo.Combustivel = Combustivel.Alcool;
            veiculo.Cor = new CorRepositorio().Selecionar(1);
            veiculo.Modelo = new ModeloRepositorio().Selecionar(1);
            veiculo.Id = 1;
            veiculo.Observacao = "Obs";
            veiculo.Placa = "ABC1234";

            repositorio.Inserir(veiculo);



        }
    }
}