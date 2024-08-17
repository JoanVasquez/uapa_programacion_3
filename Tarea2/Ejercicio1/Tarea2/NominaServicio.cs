using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class NominaServicio : ICalcularNominana
    {
        public float calcularAfp(NominaModel nomina)
        {
            return (nomina.SueldoNeto + nomina.PocentajeAFP) / 100;
        }

        public float calcularArs(NominaModel nomina)
        {
            return (nomina.SueldoNeto + nomina.PocentajeARS) / 100;
        }

        public float calcularIsr(NominaModel nomina)
        {
            return (nomina.SueldoNeto + nomina.PocentajeISR) / 100;
        }

        public float calcularTotalDescuento(NominaModel nomina)
        {
            return calcularDescuentos(nomina);
        }

        private float calcularDescuentos(NominaModel nomina)
        {
            return calcularAfp(nomina) + calcularArs(nomina) + calcularIsr(nomina); 
        }
    }
}
