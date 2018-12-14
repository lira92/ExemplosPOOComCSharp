public class GeradorBoleto
{
    private readonly IBoleto _boleto;

    public GeradorBoleto(IBoleto boleto)
    {
        _boleto = boleto;
    }

    public void MontarBoleto()
    {
        var codigoDeBarras = _boleto.GerarCodigoDeBarras();

        // Lógica para gerar o boleto.
    }
}