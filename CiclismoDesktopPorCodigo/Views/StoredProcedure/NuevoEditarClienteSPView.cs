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
    public partial class NuevoEditarClienteSPView : Form
    {
        SqlCommand comand = new SqlCommand();
        int? idClienteAEditar;
        //nuevo
        public NuevoEditarClienteSPView()
        {
            InitializeComponent();
            comand.Connection = Helper.CrearConexion();
            comand.CommandType = CommandType.StoredProcedure;
        }
        //editar
        public NuevoEditarClienteSPView(int idClienteAEditar)
        {
            InitializeComponent();
            comand.Connection = Helper.CrearConexion();
            comand.CommandType = CommandType.StoredProcedure;
            this.idClienteAEditar = idClienteAEditar;
            CargarDatosEnPantalla();
        }

        private void CargarDatosEnPantalla()
        {
            //escribimos el comando y lo ejecutamos, el resultado queda el SqldataReader
            
            comand.Parameters.Clear();
            comand.CommandText = "GetByIdCliente";
            comand.Parameters.AddWithValue("id", idClienteAEditar);
            SqlDataReader clientesReader = comand.ExecuteReader();
            if (clientesReader.Read())
            {
                txtNombre.Text = (string)clientesReader["Nombre"];
                txtNombreContacto.Text = (string)clientesReader["NombreContacto"];
                txtApellidoContacto.Text = (string)clientesReader["ApellidoContacto"];
            }
            clientesReader?.Close();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            comand.Parameters.Clear();
            comand.Parameters.AddWithValue("nombre",txtNombre.Text);
            comand.Parameters.AddWithValue("nombreContacto", txtNombreContacto.Text);
            comand.Parameters.AddWithValue("apellidoContacto", txtApellidoContacto.Text);
            if (idClienteAEditar != null)
            {
                comand.Parameters.AddWithValue("id", idClienteAEditar);
                comand.CommandText = "UpdateCliente";
            }else
            {
                comand.CommandText = "AddCliente";
            }
            comand.ExecuteNonQuery();
            this.Close();
        }
    }
}
