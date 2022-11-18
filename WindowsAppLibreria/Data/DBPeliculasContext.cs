using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using LibreriaPeliculas.Models;

namespace WindowsAppLibreria.Data
{
    public class DBPeliculasContext:DbContext
    {
        public DBPeliculasContext() : base("keyDBPeliculas") { }

        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Genero> Genero { get; set; }
        public DbSet<Clasificacion> Clasificacions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);


            //Nombre Tablas
            modelBuilder.Entity<Pelicula>().ToTable("Pelicula");
            modelBuilder.Entity<Genero>().ToTable("Genero");
            modelBuilder.Entity<Clasificacion>().ToTable("Clasificacion");

            //Primary Key
            modelBuilder.Entity<Pelicula>().HasKey(x => x.PeliculaId);
            modelBuilder.Entity<Genero>().HasKey(x => x.GeneroId);
            modelBuilder.Entity<Clasificacion>().HasKey(x => x.ClasificacionId);

            //Propiedades
            modelBuilder.Entity<Pelicula>().Property(t => t.Nombre).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Pelicula>().Property(t => t.FechaEstreno).HasColumnType("datetime").IsRequired();
            modelBuilder.Entity<Pelicula>().Property(t => t.DuracionEnMinutos).HasColumnType("int").IsRequired();
            modelBuilder.Entity<Pelicula>().Property(t => t.Idioma).HasColumnType("varchar").HasMaxLength(50).IsRequired();
            modelBuilder.Entity<Pelicula>().Property(t => t.Sinopsis).HasColumnType("varchar").HasMaxLength(200).IsRequired();

            modelBuilder.Entity<Genero>().Property(t => t.Nombre).HasColumnType("varchar").HasMaxLength(20);

            modelBuilder.Entity<Clasificacion>().Property(t => t.Tipo).HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Clasificacion>().Property(t => t.Descripcion).HasColumnType("varchar").HasMaxLength(50);

        }
    }
}
