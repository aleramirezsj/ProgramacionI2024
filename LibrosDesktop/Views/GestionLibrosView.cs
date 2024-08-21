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
    public partial class GestionLibrosView : Form
    {
        BindingSource listaLibros=new BindingSource();
        LibrosRepository repo = new LibrosRepository();

        public GestionLibrosView()
        {
            InitializeComponent();
            dataGridLibros.DataSource = listaLibros;
            CargarLibrosALaGrilla();
        }

        private async void CargarLibrosALaGrilla()
        {
            listaLibros.DataSource = await repo.ObtenerLibrosAsync();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarLibroView agregarEditarLibroView = new AgregarEditarLibroView();
            agregarEditarLibroView.ShowDialog();
            CargarLibrosALaGrilla();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var libro = (Libro)listaLibros.Current;
            //mostramos un messagebox que pregunta si está seguro que desea borrar
            DialogResult respuesta = MessageBox.Show($"¿Está seguro que quiere borrar el libro {libro.nombre} ?",
                            "Eliminar libro",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
            //si el usuario seleccionó que quiere borrar, enviamos a borrar el libro, utilizado el id y la objeto repo.
            if (respuesta == DialogResult.Yes)
            {
                await repo.EliminarAsync(libro._id);
                CargarLibrosALaGrilla();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var libro = (Libro)listaLibros.Current;

            //instanciar la ventana AgregarEditarLibro y pasarle ese id a su constructor
            //(vamos a tener que crear un nuevo constructor en ese formulario que esté preparador para recibir al id)
            AgregarEditarLibroView agregarEditarLibroView = new AgregarEditarLibroView(libro);

            //llamamos a la ventana con el método showmodal que la pone por encima
            agregarEditarLibroView.ShowDialog();

            //recargar la grilla
            CargarLibrosALaGrilla();
        }
    }
}
