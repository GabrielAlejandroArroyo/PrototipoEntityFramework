using Microsoft.EntityFrameworkCore;
using PrototipoEntityFramework.Entidades;

namespace PrototipoEntityFramework
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        // Impórtante para mapear en el orm las clase con la table de base de datos uso  public DbSet<Nombre de clase que representa una entidad > Nombre de la Tabla => Set<nombre de clase entidad>();
        // Creo una table a partir de una clase
        // Las Clase Genero, se mapeara en la base de datos como nombre de tabla Generos
        public DbSet<Genero> Generos => Set<Genero>();
    }
}