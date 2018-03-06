using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeibaEstacionamientoGjmg.Logica
{
    public interface IProcesoIngreso
    {
        bool VerificarPlaca(string placa);

        bool VerificarDia(DayOfWeek dia);

        bool ParametrosRegistroVehiculo(int Cilindraje, int TipoVehciculo, string PlacaVehiculo);

        bool parametrosRegistroComprobante(bool estado, DateTime fechaIngeso, DateTime fechaSalida, int idVehiculo, int Horas, int Valor);
    }
}
