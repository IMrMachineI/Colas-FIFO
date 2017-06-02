using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas_FIFO
{
    class FIFO
    {
        private Proceso inicio;
        public void meterProceso(Proceso nuevoProceso)
        {
         if(inicio == null)
            {
                inicio = nuevoProceso;
            }   
         else
            {
                Proceso varTemporal = inicio;
                while(varTemporal.siguiente != null)
                {
                    varTemporal = varTemporal.siguiente;
                }
                varTemporal.siguiente = nuevoProceso;
            }
        }
        public Proceso sacarProceso()
        {
            Proceso varTemporal = inicio;
            if(inicio == null)
            {
                return null;
            }
            else
            {
                inicio = inicio.siguiente;
                return varTemporal;
            }
        }
        public int verProceso()
        {
            Proceso varTemporal = inicio;
            int contador = 0;
            while(varTemporal.siguiente != null)
            {
                contador += varTemporal.duracion;
                varTemporal = varTemporal.siguiente;
            }
            contador += varTemporal.duracion;
            return contador;
        }
        public override string ToString()
        {
            Proceso varTemporal = inicio;
            string resultado = "";
            while (varTemporal != null)
            {
                resultado += varTemporal.ToString();
                varTemporal = varTemporal.siguiente;
            }
            resultado += varTemporal.ToString();
            return resultado;
        }
    }
}
