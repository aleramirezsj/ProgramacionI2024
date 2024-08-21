using CiclismoDesktopPorCodigo.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiclismoDesktopPorCodigo.Views
{
    public partial class ClientesStoredProceduresView : Form
    {
        SqlCommand comand = new SqlCommand();
        //establecemos la conexión
        public ClientesStoredProceduresView()
        {
            InitializeComponent();
            comand.Connection = Helper.CrearConexion();

            CargarDatosAGrilla();
        }

        private void CargarDatosAGrilla()
        {
            //escribimos el comando y lo ejecutamos, el resultado queda el SqldataReader
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.Clear();
            comand.CommandText = "GetAllClientes";
            SqlDataReader clientesReader = comand.ExecuteReader();

            //cargamos los datos en un dataTable para poder mostrarlo en la grilla
            DataTable clientesTable = new DataTable();
            clientesTable.Load(clientesReader);
            dataGridClientes.DataSource = clientesTable;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idClienteAEliminar = (int)dataGridClientes.CurrentRow.Cells[0].Value;
            string nombreCliente = (string)dataGridClientes.CurrentRow.Cells[1].Value;
            //mostramos un messagebox que pregunta si está seguro que desea borrar
            DialogResult respuesta = MessageBox.Show($"¿Está seguro que quiere borrar al cliente {nombreCliente} ?",
                            "Eliminar cliente",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
            //si el usuario seleccionó que quiere borrar, enviamos a borrar el cliente, utilizado el id 
            if (respuesta == DialogResult.Yes)
            {
                comand.CommandType = CommandType.StoredProcedure;
                comand.CommandText = "DeleteCliente";
                comand.Parameters.AddWithValue("id", idClienteAEliminar);
                comand.ExecuteNonQuery();

                CargarDatosAGrilla();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idClienteAEditar = (int)dataGridClientes.CurrentRow.Cells[0].Value;
            NuevoEditarClienteSPView nuevoEditarClienteSPView = new NuevoEditarClienteSPView(idClienteAEditar);
            nuevoEditarClienteSPView.ShowDialog();
            CargarDatosAGrilla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoEditarClienteSPView nuevoEditarClienteSPView = new NuevoEditarClienteSPView();
            nuevoEditarClienteSPView.ShowDialog();
            CargarDatosAGrilla();
        }
    }
}
