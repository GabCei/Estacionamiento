using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeibaEstacionamientoGjmg.Logica
{
    public interface IConsultasEstacionemiento
    {
        bool OcupacionEstacionamiento(string TipoVehiculo);
    }
}
