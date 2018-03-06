namespace CeibaEstacionamientoGjmg.Models
{
    public class InformacionModeloCapacidad
    {
        public CapacidadEstacionamiento capacidadEstacionamiento { get; set; }
        public ValorMotoAltoCilindraje valorMotoAltoCilindraje { get; set; }
    }
    public class CapacidadEstacionamiento
    {
        public int cantidadCarros { get; set; }
        public int cantidadMotos { get; set; }
    }

    public class ValorMotoAltoCilindraje
    {
        public int AltoCilindraje { get; set; }
    }
}
