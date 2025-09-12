using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tienda2998601.Controller;
using tienda2998601.Model;

namespace tienda2998601.VIew
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            guardarCliente();
        }
        private void guardarCliente()
        {

            Cliente nuevocliente = new Cliente();
            nuevocliente.Nombres = txtNombres.Text;
            nuevocliente.Documento = txtDocumento.Text;
            nuevocliente.Apellidos = txtApellidos.Text;
            nuevocliente.CorreoElectronico = txtCorreo.Text;
            nuevocliente.Direccion = txtDireccion.Text;

            //lo mandamos a la base de datos  
            ControllerClientes controller = new ControllerClientes();
            string resultado = controller.agregarCliente(nuevocliente);
            MessageBox.Show(resultado, "Guardar Cliente");
            Limpiar();

        }
        private void Limpiar()
        {
            txtID.Clear();
            txtNombres.Clear();
            txtDocumento.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }
        private void BuscarCliente() 
        {
            ControllerClientes controller = new ControllerClientes();
            Cliente cliente = controller.ObtenerClientePorDocumento(txtDocumento.Text);

            if (cliente == null)
            {
                MessageBox.Show("cliente no registrado");
            }
            else 
            {
                txtID.Text = cliente.ClienteId.ToString();
                txtDocumento.Text = cliente.Documento;
                txtNombres.Text = cliente.Nombres;
                txtApellidos.Text = cliente.Apellidos;
                txtCorreo.Text = cliente.CorreoElectronico;
                txtDireccion.Text = cliente.Direccion;

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ModificarCliente();
        }
        public void ModificarCliente() 
        {
            Cliente nuevoCliente = new Cliente
            {
                ClienteId =int.Parse(txtID.Text),
                Documento = txtDocumento.Text,
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                CorreoElectronico = txtCorreo.Text,
                Direccion = txtDireccion.Text
                };
            ControllerClientes controller = new ControllerClientes();
            string resultado = controller.ActualizarCliente(nuevoCliente);
            MessageBox.Show(resultado, "Cliente Actualizado");
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        public void Eliminar() 
        {
            ControllerClientes controller = new ControllerClientes();

            DialogResult resultado = MessageBox.Show("¿Esta seguro de eliminar el registro?", "Confirma eliminiacion",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (resultado == DialogResult.OK) 
            {
                string resul = controller.EliminarCliente(int.Parse(txtID.Text));
                MessageBox.Show(resul,"eliminar cliente");
            }
            Limpiar();
        }

    }
}
