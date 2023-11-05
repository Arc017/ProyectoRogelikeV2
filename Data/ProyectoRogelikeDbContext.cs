using Microsoft.EntityFrameworkCore;
using ProyectoRogelike.Modelo.Cofres;
using ProyectoRogelike.Modelo.Mapa;
using ProyectoRogelikeV2.Models.Personajes;

namespace ProyectoRogelikeV2.Data
{
    public class ProyectoRogelikeDbContext : DbContext
    {
        public ProyectoRogelikeDbContext() { }
        public ProyectoRogelikeDbContext(DbContextOptions<ProyectoRogelikeDbContext> options) : base(options)
        {

        }
        public DbSet<Personaje> Personaje { get; set; }
    }
}
