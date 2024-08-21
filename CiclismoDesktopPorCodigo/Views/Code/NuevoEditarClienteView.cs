using CiclismoDesktopPorCodigo.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace CiclismoDesktopPorCodigo.Views
{
    public partial class NuevoEditarClienteView : Form
    {

        SqlCommand comand = new SqlCommand();
        
        private int? idClienteAModificar;

        public NuevoEditarClienteView()
        {
            InitializeComponent();
            comand.Connection = Helper.CrearConexion();
        }

        public NuevoEditarClienteView(int idClienteAModificar)
        {
            InitializeComponent();
            comand.Connection = Helper.CrearConexion();
            this.idClienteAModificar = idClienteAModificar;
            CargarDatosEnPantalla();
        }

        private void CargarDatosEnPantalla()
        {
            comand.CommandText = $"SELECT * FROM clientes WHERE id={this.idClienteAModificar}";
            var clienteReader=comand.ExecuteReader();
            if (clienteReader != null)
            {
                if(clienteReader.Read())
                {
                    txtNombre.Text = (string)clienteReader["Nombre"];
                    txtNombreContacto.Text = (string)clienteReader["NombreContacto"];
                    txtApellidoContacto.Text = (string)clienteReader["ApellidoContacto"];
                }
            }
            clienteReader?.Close();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre=txtNombre.Text;
            string nombreContacto=txtNombreContacto.Text;   
            string apellidoContacto=txtApellidoContacto.Text;

            if (idClienteAModificar == null)
            {
                comand.CommandText = $"INSERT INTO clientes (nombre,NombreContacto,ApellidoContacto) VALUES ('{nombre}','{nombreContacto}','{apellidoContacto}')";
            }else
            {
                comand.CommandText = $"UPDATE clientes SET nombre='{nombre}',NombreContacto='{nombreContacto}',ApellidoContacto='{apellidoContacto}' WHERE id={this.idClienteAModificar}";
            }
            comand.ExecuteNonQuery();
            this.Close();
        }
    }
}
