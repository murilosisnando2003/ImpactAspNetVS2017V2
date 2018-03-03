public class VeiculoRepositorio
{
    private string _caminhoArquivoVeiculo = ConfigurationManager.Appsettings["caminhoArquivoVeiculo"]

    public void Inserir(Veiculo veiculo)
    {

        var veiculos = XDocumento.Load(_caminhoArquivoVeiculo);

        var registro = new StringWriter();
        new XmlSerializer(typeof(Veiculo)).Serialize(registro, veiculo);

        veiculos.Root.Add(XElement.Parse(registro.ToString());

        veiculos.Save(_caminhoArquivoVeiculo)

    }
}