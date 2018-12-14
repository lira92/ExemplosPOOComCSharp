public class Cliente
{
    public Cliente(int codigo, string nome, decimal rendaMensal)
    {
        Codigo = codigo;
        Nome = nome;
        RendaMensal = rendaMensal;
        ClientePremium = RendaMensal >= 5000;
    }

    public int Codigo { get; private set; }
    public string Nome { get; set; }
    public decimal RendaMensal { get; set; }
    public bool ClientePremium { get; private set; }

    public bool PromoverCliente(decimal valorEmCompras)
    {
        if (valorEmCompras >= 8000)
        {
            ClientePremium = true;
            return true;
        }
        return false;
    }
}