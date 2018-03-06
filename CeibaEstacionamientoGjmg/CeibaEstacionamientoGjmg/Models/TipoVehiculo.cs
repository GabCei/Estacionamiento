using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CeibaEstacionamientoGjmg.Models
{
    public class TipoVehiculo
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdTipoVehiculo { get; set; }

        [Required]
        public string NombreTipo { get; set; }

        public virtual ICollection<Vehiculo> vehiculo { get; set; }

        public TipoVehiculo()
        {
            this.vehiculo = new HashSet<Vehiculo>();
        }
    }
}
