﻿using CiclismoDesktopPorCodigo.Modelos;
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
    public partial class NuevoEditarClienteORMView : Form
    {

        CiclismoContext context=new CiclismoContext();
        
        private Cliente? cliente;

        public NuevoEditarClienteORMView()
        {
            InitializeComponent();
            this.cliente = new Cliente();
        }

        public NuevoEditarClienteORMView(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            CargarDatosEnPantalla();
        }

        private void CargarDatosEnPantalla()
        {
            txtNombre.Text = cliente?.Nombre;
            txtNombreContacto.Text = cliente?.NombreContacto;
            txtApellidoContacto.Text = cliente?.ApellidoContacto;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cliente.Nombre=txtNombre.Text;
            cliente.NombreContacto=txtNombreContacto.Text;   
            cliente.ApellidoContacto=txtApellidoContacto.Text;

            if (cliente.Id == 0)
            {
                context.Clientes.Add(cliente);
            }else
            {
                context.Clientes.Update(cliente);
            }
            context.SaveChanges();
            this.Close();
        }
    }
}
