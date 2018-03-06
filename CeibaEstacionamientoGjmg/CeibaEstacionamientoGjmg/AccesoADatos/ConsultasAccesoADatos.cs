using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CeibaEstacionamientoGjmg.Models;

namespace CeibaEstacionamientoGjmg.AccesoADatos
{
    public class ConsultasAccesoADatos : IConsultasAccesoADatos
    {
        private IRepositorioGenerico<Comprobante> objetoRepositorio { get; }
        private DbEstacionamientoContext db { get; }

        public ConsultasAccesoADatos()
        {
            db = new DbEstacionamientoContext();

            objetoRepositorio = new RepositorioGenerico<Comprobante>(db);
        }
        public List<ModeloCapacidad> CapacidadActual()
        {
            var ConsultaCapacidad = from comprobante in db.Comprobante
                                    join vehiculo in db.Vehiculo on comprobante.IdVehiculo equals vehiculo.IdVehiculo
                                    join tipoVehiculo in db.TipoVehiculo on vehiculo.IdTipoVehiculo equals tipoVehiculo.IdTipoVehiculo
                                    where comprobante.EstadoComprobante == false
                                    group tipoVehiculo by new { tipoVehiculo.NombreTipo } into grupo
                                    select new ModeloCapacidad
                                    {
                                        CapacidadTipoVehiculo = grupo.Key.NombreTipo,
                                        CapacidadCantidadVehiculos = grupo.Count()
                                    };
            return ConsultaCapacidad.ToList();
        }
    }
}
