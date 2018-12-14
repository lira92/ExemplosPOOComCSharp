using System;

namespace Atributos
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente meucliente = new Cliente();
            meucliente.codigo = 1;
            meucliente.nome = "João Da Silva";
            meucliente.rendaMensal = 2300;
            meucliente.clientePremium = true;
        }
    }
}
