public static class GeradorArquivoBoleto
{
    public static void GerarArquivoBoleto<T>(T boleto) where T: IBoleto
    {
        var codigoDeBarras = boleto.GerarCodigoDeBarras();
        // Restante da lógica para gerar o boleto
    }
}