using LibreriaPeliculas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppLibreria.Model;

namespace WindowsAppLibreria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            AdmPelicula.Insertar(new Pelicula("Pepe",new DateTime(1999,2,20),136,"Ingles","buena Peli", new Genero("Terror"),new Clasificacion()));

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            gridPeliculas.DataSource = AdmPelicula.Listar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            AdmPelicula.Eliminar(id);
        }

        private void btnMostrarPorGenero_Click(object sender, EventArgs e)
        {
           gridPeliculas.DataSource= AdmPelicula.Buscar(txtGenero.Text);
        }
    }
}
