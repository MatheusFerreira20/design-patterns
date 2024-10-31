using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Personagem : IAcao
    {
        public void andar(string jogador)
        {
            Console.WriteLine(jogador + "ANDOU PARA FRENTE!");
        }

        public void atirar()
        {
            Console.WriteLine("Atirou no jogo");
        }
    }
}
