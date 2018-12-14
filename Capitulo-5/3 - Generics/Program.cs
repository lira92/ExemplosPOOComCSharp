using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var menuFilho = new Menu();
            var menuPai = new Menu();
            var menu = new Menu();
            var arvoreDeMenus = new Tree<Menu>(menuPai, menu);
            arvoreDeMenus.AddChild(menuFilho);

            Console.ReadKey();
        }
    }

    public class Menu
    {
        public string Nome { get; set; }
    }
}
