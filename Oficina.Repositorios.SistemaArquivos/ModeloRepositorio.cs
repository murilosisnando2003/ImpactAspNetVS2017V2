public class ModeloRepositorio
{
    public List<Modelo> SelecionarPorMarca(int marcaId)
    {
        private string _caminhoArquivoModelo = ConfigurationManager.Appsettings["caminhoArquivomodelo"]

        var modelos = new List<Modelo>();
        var arquivoXml = XDocumento.Load(_caminhoArquivoModelo);

        foreach (var elemento in arquivoXml.Decendents("modelo"))
        {
            if (marcaId.ToString()== elemento.Element("marcaId").Value)
            {
                var modelo = new Modelo();
                modelo.Id = Convert.ToInt32(elemento.Element("id").Value);
                modelo.Nome = elemento.Element("nome").Value;
                modelo.Marca = new MarcaRepositorio().Selecionar();

                modelos.Add();
            }
        }

        return modelos;
    }
}