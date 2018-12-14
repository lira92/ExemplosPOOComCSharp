using System.Collections.Generic;

public class Cliente
{
    private const decimal RENDA_MINIMA_PREMIUM = 5000;
    private const decimal RENDA_MINIMA_MASTER = 8500;
    private const decimal VALOR_MINIMO_EM_COMPRAS_PREMIUM = 8000;
    private const decimal VALOR_MINIMO_EM_COMPRAS_MASTER = 10000;
    public Cliente(int codigo, string nome, decimal rendaMensal)
    {
        Codigo = codigo;
        Nome = nome;
        RendaMensal = rendaMensal;
        Classificacao = DefinirClassificacao();
        Vendas = new List<Venda>();
    }

    public int Codigo { get; private set; }
    public string Nome { get; set; }
    public decimal RendaMensal { get; set; }
    public EClassificacao Classificacao { get; private set; }
    public List<Venda> Vendas { get; set; }

    public void AdicionarVenda(Venda venda)
    {
        Vendas.Add(venda);
    }

    public decimal CalcularTotalDeVendas()
    {
        decimal total = 0;
        foreach (var venda in Vendas)
        {
            total = total + venda.Valor;
        }
        return total;
    }

    private EClassificacao DefinirClassificacao()
    {
        if (RendaMensal < RENDA_MINIMA_PREMIUM)
        {
            return EClassificacao.Convencional;
        }
        if (RendaMensal < RENDA_MINIMA_MASTER)
        {
            return EClassificacao.Premium;
        }
        return EClassificacao.Master;
    }
}