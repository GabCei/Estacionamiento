using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeibaEstacionamientoGjmg.AccesoADatos
{
    public interface IRegistrosAccesoADatos
    {
        bool ResgistrarVehiculo(int Cilindraje, int Tipo, string Placa);

        bool RegistroComprobante(bool estado, DateTime fechaIngeso, DateTime fechaSalida, int idVehiculo, int Horas, int Valor);
    }
}
