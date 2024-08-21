using EjerciciosDePrueba.Models;
using EjerciciosDePrueba.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrosDesktop.Views
{
    public partial class AgregarEditarLibroView : Form
    {
        private LibrosRepository repo = new LibrosRepository();
        private Libro libro;

        //nuevo 
        public AgregarEditarLibroView()
        {
            InitializeComponent();
            this.libro = new Libro();
        }

        //editar
        public AgregarEditarLibroView(Libro libro)
        {
            this.libro = libro;
            InitializeComponent();
            CargarDatosLibroEnPantalla();
        }

        private void CargarDatosLibroEnPantalla()
        {
            txtNombre.Text = libro.nombre;
            txtAutor.Text = libro.autor;
            txtEditorial.Text = libro.editorial;
            txtPortadaUrl.Text = libro.portada_url;
            txtGenero.Text = libro.genero;
            txtSinopsis.Text = libro.sinopsis;
            numericPaginas.Value = libro.paginas;
            pictureBoxPortada.ImageLocation = libro.portada_url;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            this.libro.nombre = txtNombre.Text;
            this.libro.autor = txtAutor.Text;
            this.libro.genero = txtGenero.Text;
            this.libro.portada_url = txtPortadaUrl.Text;
            this.libro.sinopsis = txtSinopsis.Text;
            this.libro.paginas= (int)numericPaginas.Value;
            this.libro.editorial = txtEditorial.Text;

            if(this.libro._id!=null)
            {
                await repo.ActualizarAsync(this.libro);
            }
            else
            {
                await repo.AgregarAsync(this.libro);
            }
            
            this.Close();
        }
    }
}
