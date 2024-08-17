using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class NominaModel
    {
        private float sueldoNeto;
        private float pocentajeAFP;
        private float pocentajeARS;
        private float porcentajeISR;

        public float SueldoNeto
        {
            get { return sueldoNeto; }
            set { sueldoNeto = value; }
        }
        public float PocentajeAFP
        {
            get { return pocentajeAFP; }
            set { pocentajeAFP = value; }
        }
        public float PocentajeARS
        {
            get { return pocentajeARS; }
            set { pocentajeARS = value; }
        }
        public float PocentajeISR
        {
            get { return porcentajeISR; }
            set { porcentajeISR = value; }
        }
    }
}
