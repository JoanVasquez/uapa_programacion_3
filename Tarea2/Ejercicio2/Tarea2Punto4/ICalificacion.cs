using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2Punto4
{
    internal interface ICalificacion
    {
        int calcularNota(CalificacionModelo calificacionModelo);
        string calcularResultado(CalificacionModelo calificacionModelo);
        char calcularLiteral(CalificacionModelo calificacionModelo);
    }
}
