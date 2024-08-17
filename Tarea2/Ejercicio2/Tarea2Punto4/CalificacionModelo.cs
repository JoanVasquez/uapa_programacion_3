using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2Punto4
{
    internal class CalificacionModelo
    {
        private int examen;
        private int plataforma;
        private int actitudesValores;
        private int trabajoFinal;

        public int Examen {  get { return examen; } set { examen = value; } }
        public int Plataforma { get { return plataforma; } set { plataforma = value; } }
        public int ActitudesValores { get { return actitudesValores; } set { actitudesValores = value; } }
        public int TrabajoFinal { get { return trabajoFinal; } set { trabajoFinal = value; } }
    }
}
