using LibreriaPeliculas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsAppLibreria.Data;

namespace WindowsAppLibreria.Model
{
    public static class AdmPelicula
    {
        private static DBPeliculasContext context = new DBPeliculasContext();
        public static int Insertar(Pelicula pelicula)
        {
            int filasAfectadas = 0;
            context.Peliculas.Add(pelicula);
            filasAfectadas = context.SaveChanges();

            return filasAfectadas;
        }
        public static int Eliminar(int idPelicula)
        {
            int filasAfectadas = 0;
            var pelicula=context.Peliculas.Find(idPelicula);

            if (pelicula != null) context.Peliculas.Remove(pelicula);

            filasAfectadas = context.SaveChanges();

            return filasAfectadas;
        }

        public static List<Pelicula> Listar()
        {
            return context.Peliculas.ToList();
        }
        public static List<Pelicula> Buscar(string genero)
        {
            List<Pelicula> DBpeliculas = new List<Pelicula>();
            List<Pelicula> peliculasGenero = new List<Pelicula>();

            DBpeliculas = context.Peliculas.ToList();

            foreach (var pelicula in DBpeliculas)
            {
                if (pelicula.Genero !=null)
                {
                    if (pelicula.Genero.Nombre.ToUpper() == genero.ToUpper())
                    {
                        peliculasGenero.Add(pelicula);
                    }
                }
                
            }

            return peliculasGenero;
        }
    }
}
