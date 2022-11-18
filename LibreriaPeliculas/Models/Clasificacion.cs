using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPeliculas.Models
{
    public class Clasificacion
    {
        #region constructores
        public Clasificacion() { }

        public Clasificacion( string tipo, string descripcion)
        {
            Tipo = tipo;
            Descripcion = descripcion;
        }
        #endregion

        #region propiedades
        public int ClasificacionId { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }

        #endregion

        #region propiedades navegacion
        public List<Pelicula> Peliculas { get; set; }
        #endregion
    }
}
