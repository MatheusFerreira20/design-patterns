using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Facade
    {
        private Guerreiros guerreiros;
        private ColetaRecurso recurso;
        private Armameneto armameneto;

        public Facade()
        {
            this.armameneto = new Armameneto();
            this.recurso = new ColetaRecurso();
            this.guerreiros = new Guerreiros();
        }

        public void CriarArmamento()
        {
            Console.WriteLine("Operação Criar armamento");
            this.recurso.Responsabilidade();
            this.armameneto.Responsabilidade();
        }

        public void TreinarGuerreiros()
        {
            Console.WriteLine("Operação treinar guerreiros");
            this.recurso.Responsabilidade();
            this.guerreiros.Responsabilidade();

        }
    }
}
