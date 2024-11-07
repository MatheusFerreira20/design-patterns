using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class ComplexoComando : ICommand
    {
        private Receiver receiver;
        private string _a;
        private string _b;

        public ComplexoComando(Receiver receiver, string a, string b)
        {
            this.receiver = receiver;
            _a = a;
            _b = b;
        }

        public void Executar()
        {
            this.receiver.PrimeiroPedido(_a);
            this.receiver.SegundoPedido(_b);
        }
    }
}
