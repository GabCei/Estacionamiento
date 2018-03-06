using CeibaEstacionamientoGjmg.AccesoADatos;
using CeibaEstacionamientoGjmg.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CeibaEstacionamientoGjmg.Logica
{
    public class ProcesoIngreso : IProcesoIngreso
    {
        private IRegistrosAccesoADatos registrosAccesoA { get; set; }

        public ProcesoIngreso()
        {
            registrosAccesoA = new RegistrosAccesoADatos();
        }

        public bool VerificarPlaca(string placa)
        {
            string DatosJson = File.ReadAllText(@"C:\Users\gabriel.munoz\source\repos\CeibaEstacionamientoGjmg\CeibaEstacionamientoGjmg\AccesoADatos\RestriccionesEstacionamiento.json");

            ModeloRestricciones informacionJson = JsonConvert.DeserializeObject<ModeloRestricciones>(DatosJson);

            Array letra = placa.ToCharArray(0, 1);

            if (letra.GetValue(0).ToString() == informacionJson.restriccionLetra.LetraPlaca)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool VerificarDia(DayOfWeek dia)
        {
            string Json = File.ReadAllText(@"C:\Users\gabriel.munoz\source\repos\CeibaEstacionamientoGjmg\CeibaEstacionamientoGjmg\AccesoADatos\RestriccionesEstacionamiento.json");

            ModeloRestricciones informacionJson = JsonConvert.DeserializeObject<ModeloRestricciones>(Json);

            var contieneDia = informacionJson.restriccionDias.Dias.Where(x => x.dia == dia.ToString());

            if (contieneDia.Count() > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ParametrosRegistroVehiculo(int Cilindraje, int TipoVehciculo, string PlacaVehiculo)
        {

            if (registrosAccesoA.ResgistrarVehiculo(Cilindraje, TipoVehciculo, PlacaVehiculo) ==  true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool parametrosRegistroComprobante(bool estado, DateTime fechaIngeso, DateTime fechaSalida, int idVehiculo, int Horas, int Valor)
        {
            if (registrosAccesoA.RegistroComprobante(estado, fechaIngeso, fechaSalida, idVehiculo, Horas, Valor) == true)
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
