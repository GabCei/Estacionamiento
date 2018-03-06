using CeibaEstacionamientoGjmg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CeibaEstacionamientoGjmg.AccesoADatos
{
    public class RegistrosAccesoADatos : IRegistrosAccesoADatos
    {
        private IRepositorioGenerico<Vehiculo> ObjetoRepositorio { get; }
        private DbEstacionamientoContext db { get; }

        public RegistrosAccesoADatos()
        {
            db = new DbEstacionamientoContext();

            ObjetoRepositorio = new RepositorioGenerico<Vehiculo>(db);
        }
        public bool ResgistrarVehiculo(int Cilindraje, int Tipo, string Placa)
        {
            Vehiculo vehiculo = new Vehiculo();

            vehiculo.Cilindraje = Cilindraje;
            vehiculo.IdTipoVehiculo = Tipo;
            vehiculo.Placa = Placa;

            ObjetoRepositorio.Add(vehiculo);

            ObjetoRepositorio.Save();

            return true;
        }

        public bool RegistroComprobante(bool estado, DateTime fechaIngeso, DateTime fechaSalida, int idVehiculo, int Horas, int Valor)
        {
            //Comprobante comprobante = new Comprobante();

            //comprobante.EstadoComprobante = estado;
            //comprobante.FechaIngeso = fechaIngeso;
            //comprobante.FechaSalida = fechaSalida;
            //comprobante.IdVehiculo = idVehiculo;
            //comprobante.TotalHoras = Horas;
            //comprobante.ValorTotal = Valor;

            //ObjetoRepositorio.Add(comprobante);
            //ObjetoRepositorio.Save();

            return true;
        }
    }
}
//tener pendiente si se usa un try chatch para devolver una exepción en caso de que no se envie un dato valido.