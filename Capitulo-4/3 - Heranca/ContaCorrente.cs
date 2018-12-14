public sealed class ContaCorrente : Conta
{
    public decimal Limite { get; private set; }

    override public void Saque(decimal valor)
    {
        if (valor <= (Saldo + Limite))
        {
            Saldo -= valor;
        }
    }
}