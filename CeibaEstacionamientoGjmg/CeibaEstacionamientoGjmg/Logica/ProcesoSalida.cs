using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeibaEstacionamientoGjmg.Logica
{
    public class ProcesoSalida : IProcesoSalida
    {
        public bool ContarHoras(DateTime FechaIngreso, DateTime FechaSalida)
        {
            TimeSpan horas = FechaSalida - FechaIngreso;

            if (horas.TotalHours > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
