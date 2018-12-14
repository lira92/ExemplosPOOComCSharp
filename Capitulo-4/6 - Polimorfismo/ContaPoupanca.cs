public sealed class ContaPoupanca : Conta
{
    public override void Saque(decimal valor)
    {
        if (valor <= Saldo)
        {
            Saldo -= valor;
        }
    }
}