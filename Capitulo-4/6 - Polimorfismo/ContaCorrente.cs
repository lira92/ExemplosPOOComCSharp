public sealed class ContaCorrente : Conta
{
    public decimal Limite { get; private set; }

    public override void Saque(decimal valor)
    {
        if (valor <= (Saldo + Limite))
        {
            Saldo -= valor;
        }
    }
}