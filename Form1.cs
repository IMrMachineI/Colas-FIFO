using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas_FIFO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static Random numRandom = new Random();
        FIFO nuevaColaFIFO = new FIFO();
        Proceso nuevoProceso;
        private void btnSimular_Click(object sender, EventArgs e)
        {
            int probabilidadAOcurrir = 0;
            int procesosAgregados = 0;
            int procesosPendientes = 0;
            int procesosAtendidos = 0;
            for(int i = 1;i<=200;i++)
            {
                probabilidadAOcurrir = numRandom.Next(1, 4);
                if(probabilidadAOcurrir == 1)
                {
                    nuevoProceso = new Proceso();
                    nuevaColaFIFO.meterProceso(nuevoProceso);
                    procesosAgregados++;
                }
                
            }
        }
    }
}
