public class Conta
{
    public decimal Saldo { get; protected set; }

    public void Depositar(decimal valor)
    {
        Saldo += valor;
    }

    public virtual void Saque(decimal valor)
    {
        if (valor <= Saldo)
        {
            Saldo -= valor;
        }
    }
}