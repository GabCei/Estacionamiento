using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CeibaEstacionamientoGjmg.Models
{
    public class Comprobante
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdComprobante { get; set; }

        [Required]
        public int IdVehiculo { get; set; }

        [Required]
        public DateTime FechaIngeso { get; set; }

        public DateTime FechaSalida { get; set; }

        public int TotalHoras { get; set; }

        public int ValorTotal { get; set; }

        public bool EstadoComprobante { get; set; }

        [ForeignKey("IdVehiculo")]
        public virtual Vehiculo Vehiculo { get; set; }
    }
}
