using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPeliculas.Models
{
    public class Pelicula
    {
        #region constructores
        public Pelicula() { }

        public Pelicula( string nombre, DateTime fechaEstreno, int duracionEnMinutos, string idioma, string sinopsis, Genero genero, Clasificacion clasificacion)
        {
            
            Nombre = nombre;
            FechaEstreno = fechaEstreno;
            DuracionEnMinutos = duracionEnMinutos;
            Idioma = idioma;
            Sinopsis = sinopsis;
            Genero = genero;
            Clasificacion = clasificacion;
        }


        #endregion

        #region propiedades
        public int PeliculaId { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaEstreno { get; set; }
        public int DuracionEnMinutos { get; set; }
        public string Idioma { get; set; }
        public string Sinopsis { get; set; }
        #endregion

        #region propiedades navegacion
        public Genero Genero { get; set; }
        public Clasificacion Clasificacion { get; set; }
        #endregion
    }
}
