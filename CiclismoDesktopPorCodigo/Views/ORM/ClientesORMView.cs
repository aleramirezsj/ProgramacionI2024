using CiclismoDesktopPorCodigo.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiclismoDesktopPorCodigo.Views
{
    public partial class ClientesORMView : Form
    {
        CiclismoContext context = new CiclismoContext();
        BindingSource listaClientes = new BindingSource();

        public ClientesORMView()
        {
            InitializeComponent();
            dataGridClientes.DataSource = listaClientes;
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            listaClientes.DataSource = context.Clientes.ToList();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var cliente = (Cliente)listaClientes.Current;
            //mostramos un messagebox que pregunta si está seguro que desea borrar
            DialogResult respuesta = MessageBox.Show($"¿Está seguro que quiere borrar al cliente {cliente.Nombre} ?",
                            "Eliminar cliente",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
            //si el usuario seleccionó que quiere borrar, enviamos a borrar el cliente, utilizado el id 
            if (respuesta == DialogResult.Yes)
            {
                context.Clientes.Remove(cliente);
                context.SaveChanges();
                CargarGrilla();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoEditarClienteORMView nuevoEditarClienteORMView = new NuevoEditarClienteORMView();
            nuevoEditarClienteORMView.ShowDialog();
            CargarGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var cliente = (Cliente)listaClientes.Current;
            NuevoEditarClienteORMView nuevoEditarClienteORMView = new NuevoEditarClienteORMView(cliente);
            nuevoEditarClienteORMView.ShowDialog();
            CargarGrilla();
        }
    }
}
