using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CeibaEstacionamientoGjmg.Models
{
    public class Vehiculo
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdVehiculo { get; set; }

        [Required]
        public int IdTipoVehiculo { get; set; }

        [Required]
        [MaxLength(7, ErrorMessage = "La placa no debe contener más de 7 caracteres")]
        public string Placa { get; set; }

        public int Cilindraje { get; set; }

        [ForeignKey("IdTipoVehiculo")]
        public virtual TipoVehiculo TipoVehiculo { get; set; }

        public virtual ICollection<Comprobante> comprobante { get; set; }

        public Vehiculo()
        {
            this.comprobante = new HashSet<Comprobante>();
        }
    }
}
