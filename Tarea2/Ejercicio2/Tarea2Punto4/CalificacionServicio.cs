using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2Punto4
{
    internal class CalificacionServicio : ICalificacion
    {
       
        public char calcularLiteral(CalificacionModelo calificacionModelo)
        {
            int totalSumaCalificacion = sumarCalificaciones(calificacionModelo);
            if(totalSumaCalificacion >= 90) return 'A';
            else if (totalSumaCalificacion >= 80) return 'B';
            else if (totalSumaCalificacion >= 70) return 'C';
            else if (totalSumaCalificacion >= 60) return 'D';

            return 'F';
        }

        public int calcularNota(CalificacionModelo calificacionModelo)
        {
            return sumarCalificaciones(calificacionModelo);
        }

        public string calcularResultado(CalificacionModelo calificacionModelo)
        {
            int totalSumaCalificacion = sumarCalificaciones(calificacionModelo);
            if(totalSumaCalificacion >= 70)
            {
                return "Aprovado";
            }
            return "Reprovado";
        }


        private int sumarCalificaciones(CalificacionModelo calificacionModelo)
        {
            return calificacionModelo.Examen + calificacionModelo.Plataforma + calificacionModelo.ActitudesValores + calificacionModelo.TrabajoFinal;
        }
    }
}
