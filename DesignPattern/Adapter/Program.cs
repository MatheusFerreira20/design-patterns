using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem player = new Personagem();
            Console.WriteLine("Começou o jogo");
            player.andar("Shaolin ");
            player.atirar();

            Console.ReadKey();
        }
    }
}
