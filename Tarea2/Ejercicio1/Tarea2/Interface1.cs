using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal interface ICalcularNominana
    {
        float calcularAfp(NominaModel nomina);
        float calcularArs(NominaModel nomina);
        float calcularIsr(NominaModel nomina);
        float calcularTotalDescuento(NominaModel nomina);
    }
}
