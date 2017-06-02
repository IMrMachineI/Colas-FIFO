using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas_FIFO
{
    class Proceso
    {
        private int _duracion;
        static Random numAleatorio = new Random();
        public Proceso siguiente;
        public Proceso()
        {
            _duracion = numAleatorio.Next(4,14);
        }
        public int duracion
        {
            get { return _duracion; }
        }
        public void reducirProceso()
        {
            _duracion--;
        }
        public override string ToString()
        {
            return "Duracion: "+_duracion+", ";
        }
    }
}
