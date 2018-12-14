using System;

namespace Constantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente meucliente = new Cliente(1, "João da Silva", 2500);
            // Aqui meucliente.ClientePremium é false
            meucliente.PromoverCliente(5000);
            // Aqui meucliente.ClientePremium passa a ser true
        }
    }
}
