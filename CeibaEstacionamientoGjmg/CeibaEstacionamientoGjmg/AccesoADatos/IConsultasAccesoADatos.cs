using CeibaEstacionamientoGjmg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeibaEstacionamientoGjmg.AccesoADatos
{
    public interface IConsultasAccesoADatos
    {
        List<ModeloCapacidad> CapacidadActual();
    }
}
