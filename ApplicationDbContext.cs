using Microsoft.EntityFrameworkCore;
using PrototipoEntityFramework.Entidades;

namespace PrototipoEntityFramework
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        // Creo una table a partir de una clase
        // Las Clase Genero, se mapeara en la base de datos como nombre de tabla Generos
        public DbSet<Genero> Generos => Set<Genero>();
    }
}