using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var ehMeuAniversario = DateTime.Now.EhMeuAniversario();
            ehMeuAniversario = new DateTime(1992, 7, 6).EhMeuAniversario();
        }
    }
}
