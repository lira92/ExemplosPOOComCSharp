using System;

namespace MembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            var cpfvalido = ValidadorDeCpf.Validar("12345678910");
            
            VisualizacoesDaPagina.Contador++;
        }
    }
}
