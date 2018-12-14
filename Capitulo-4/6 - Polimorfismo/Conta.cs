public abstract class Conta
{
    public decimal Saldo { get; protected set; }

    public void Depositar(decimal valor)
    {
        Saldo += valor;
    }

    public abstract void Saque(decimal valor);
}