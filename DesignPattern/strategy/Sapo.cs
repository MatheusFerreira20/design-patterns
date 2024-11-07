using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy
{
    public class Sapo : IAajuda
    {
        public string Ajudar(Ajuda pedido)
        {
            return "Sou um sapo e posso ajudar a você a pular!";
        }
    }
}
