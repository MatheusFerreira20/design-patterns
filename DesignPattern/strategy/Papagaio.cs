using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy
{
    public class Papagaio : IAajuda
    {
        public string Ajudar(Ajuda pedido)
        {
            return "Sou um papagaio e posso ajudar a você a voar!";
        }
    }
}
