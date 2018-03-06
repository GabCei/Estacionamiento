using System.Collections.Generic;

namespace CeibaEstacionamientoGjmg.Models
{
    public class ModeloRestricciones
    {
        public RestriccionLetra restriccionLetra { get; set; }
        public RestriccionDias restriccionDias { get; set; }
    }
    public class RestriccionLetra
    {
        public string LetraPlaca { get; set; }
    }

    public class RestriccionDias
    {
        public List<Dias> Dias { get; set; }
    }
    public class Dias
    {
        public string dia { get; set; }
    }
}
