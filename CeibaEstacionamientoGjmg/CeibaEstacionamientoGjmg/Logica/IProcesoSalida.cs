using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeibaEstacionamientoGjmg.Logica
{
    public interface IProcesoSalida
    {
        bool ContarHoras(DateTime FechaIngreso, DateTime FechaSalida);
    }
}
