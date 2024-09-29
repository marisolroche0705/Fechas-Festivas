using Fecha_Festiva.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Fecha_Festiva.Infraestructura.Persistencia.Contextos
{
    public class Fecha_FestivaContex : DbContext
    {
        public Fecha_FestivaContex(DbContextOptions<Fecha_FestivaContex> options) : base(options)
        {
        }
        public DbSet<Seleccion> Selecciones { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Seleccion>(seleccion =>
            {
                seleccion.HasKey(s => s.Id);
                seleccion.HasIndex(s => s.Dia);
                seleccion.HasIndex(s => s.Mes);
            });

        }
    }
}
