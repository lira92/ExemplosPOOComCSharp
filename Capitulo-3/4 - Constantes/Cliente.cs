public class Cliente
{
    private const decimal RENDA_MINIMA = 5000;
    private const decimal VALOR_MINIMO_EM_COMPRAS = 8000;

    public Cliente(int codigo, string nome, decimal rendaMensal)
    {
        Codigo = codigo;
        Nome = nome;
        RendaMensal = rendaMensal;
        ClientePremium = RendaMensal >= RENDA_MINIMA;
    }

    public int Codigo { get; private set; }
    public string Nome { get; set; }
    public decimal RendaMensal { get; set; }
    public bool ClientePremium { get; private set; }

    public bool PromoverCliente(decimal valorEmCompras)
    {
        if (valorEmCompras >= VALOR_MINIMO_EM_COMPRAS)
        {
            ClientePremium = true;
            return true;
        }
        return false;
    }
}