using Microsoft.EntityFrameworkCore;
using PrototipoEntityFramework.Entidades;

namespace PrototipoEntityFramework
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }


        // Definiendo en ApiFluent
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Trabajando con api Fluent
            //modelBuilder.Entity<Genero>().HasKey(g => g.Id);
            // Resticciones en el Backend Genero
            //modelBuilder.Entity<Genero>().Property(g => g.Nombre).HasMaxLength(150);


            // Resticciones en el Backend Actor
            //modelBuilder.Entity<Actor>().Property(a => a.Nombre).HasMaxLength(150);
            modelBuilder.Entity<Actor>().Property(a => a.FechaNacimiento).HasColumnType("date");
            modelBuilder.Entity<Actor>().Property(a => a.Fortuna).HasPrecision(18, 2);


            // Resticciones en el Backend Peliculas
            //modelBuilder.Entity<Pelicula>().Property(p => p.Titulo).HasMaxLength(150);
            modelBuilder.Entity<Pelicula>().Property(p => p.FechaEstreno).HasColumnType("date");


            // Resticciones en el Backend Comentario
            modelBuilder.Entity<Comentario>().Property(c => c.Contenido).HasMaxLength(500);

        }

        //Sobresbitr que todos los campos stirng se preconfiguren en string de 150
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(150);

        }

        // Impórtante para mapear en el orm las clase con la table de base de datos uso  public DbSet<Nombre de clase que representa una entidad > Nombre de la Tabla => Set<nombre de clase entidad>();
        // Creo una table a partir de una clase
        // Las Clase Genero, se mapeara en la base de datos como nombre de tabla Generos
        public DbSet<Genero> Generos => Set<Genero>();
        public DbSet<Actor> Actores => Set<Actor>();

        public DbSet<Pelicula> Peliculas => Set<Pelicula>();

        public DbSet<Comentario> Comentarios => Set<Comentario>();


    }
}