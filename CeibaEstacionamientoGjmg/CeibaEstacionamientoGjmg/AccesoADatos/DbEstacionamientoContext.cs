using CeibaEstacionamientoGjmg.Models;
using Microsoft.EntityFrameworkCore;

namespace CeibaEstacionamientoGjmg.AccesoADatos
{
    public class DbEstacionamientoContext : DbContext
    {
        public DbEstacionamientoContext()
        {

        }

        public DbEstacionamientoContext(DbContextOptions<DbEstacionamientoContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=GABRIEL-MUNOZ\SQLEXPRESS;Database=DbEstacionamiento;Trusted_Connection=True");
            }
        }
        public virtual DbSet<TipoVehiculo> TipoVehiculo { get; set; }
        public virtual DbSet<Vehiculo> Vehiculo { get; set; }
        public virtual DbSet<Comprobante> Comprobante { get; set; }
    }
}
