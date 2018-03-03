using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Oficina.Dominio;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class CorRepositorio
    {
        public List<Marca> Selecionar()
        {
            var marcas = new List<Marca>();

            foreach (var linha in File.ReadAllLines(@"Dados\Marca.txt"))
            {
                var marca = new Marca();
                marca.Id = Convert.ToInt32(linha.Substring(0, 5));
                marca.Nome = linha.Substring(5);

                marcas.Add(marca);

            }

            return marcas;

        }
    }
}
