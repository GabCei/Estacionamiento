using CeibaEstacionamientoGjmg.AccesoADatos;
using CeibaEstacionamientoGjmg.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CeibaEstacionamientoGjmg.Logica
{
    public class ConsultasEstacionemiento : IConsultasEstacionemiento
    {
        private IConsultasAccesoADatos consultasAccesoADatos { get; set; }
        public ConsultasEstacionemiento()
        {
            consultasAccesoADatos = new ConsultasAccesoADatos();
        }
        public bool OcupacionEstacionamiento(string TipoVehiculo)
        {
            List<ModeloCapacidad> lista = consultasAccesoADatos.CapacidadActual();

            string informacionJson = File.ReadAllText(@"C:\Users\gabriel.munoz\source\repos\CeibaEstacionamientoGjmg\CeibaEstacionamientoGjmg\AccesoADatos\CapacidadEstacionamiento.json");

            InformacionModeloCapacidad infoJson = JsonConvert.DeserializeObject<InformacionModeloCapacidad>(informacionJson);

            var listaCapacidad = consultasAccesoADatos.CapacidadActual().Where(x => x.CapacidadTipoVehiculo == TipoVehiculo).FirstOrDefault();

            if (TipoVehiculo == "Carro")
            {
                if (infoJson.capacidadEstacionamiento.cantidadCarros == listaCapacidad.CapacidadCantidadVehiculos)
                {
                    throw new Exception("No hay Cupo disponible para Carro");
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (infoJson.capacidadEstacionamiento.cantidadMotos == listaCapacidad.CapacidadCantidadVehiculos)
                {
                    throw new Exception("No hay Cupo disponible para Moto");
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
