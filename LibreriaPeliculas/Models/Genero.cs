using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPeliculas.Models
{
    public class Genero
    {
        #region constructores
        public Genero() { }
        public Genero(string nombre)
        {
            Nombre = nombre;
        }
        #endregion

        #region propiedades
        public int GeneroId { get; set; }
        public string Nombre { get; set; }
        #endregion

        #region propiedades navegacion
        public List<Pelicula> Peliculas { get; set; }
        #endregion
    }
}
