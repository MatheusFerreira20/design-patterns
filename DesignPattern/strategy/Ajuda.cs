using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy
{
    public class Ajuda
    {
        private IAajuda _AIjuda;

        public Ajuda(IAajuda iajuda)
        {
            _AIjuda = iajuda;
        }

        public string Ajudar()
        {
            return _AIjuda.Ajudar(this);
        }
    }
}
