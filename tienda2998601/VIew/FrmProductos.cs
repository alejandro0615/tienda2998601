using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tienda2998601.Controller;
using tienda2998601.Model;

namespace tienda2998601.VIew
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            guardarProducto();
        }
        private void guardarProducto()
        {

            Producto nuevoProducto = new Producto();
            nuevoProducto.NombreProducto = txtNombres.Text;
            nuevoProducto.Descripcion = txtDescripcion.Text;
            nuevoProducto.Precio = int.Parse(txtPrecio.Text);
            nuevoProducto.Stock = int.Parse(txtStock.Text);

            //lo mandamos a la base de datos  
            ControllerProductos controller = new ControllerProductos();
            string resultado = controller.agregarProducto(nuevoProducto);
            MessageBox.Show(resultado, "Guardar Pedido");
            Limpiar();

        }
        private void Limpiar()
        {
            txtProducto_id.Clear();
            txtNombres.Clear();
            txtPrecio.Clear();
            txtDescripcion.Clear();
            txtStock.Clear();
            ;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarProducto();
        }
        private void BuscarProducto()
        {
            ControllerProductos controller = new ControllerProductos();
            Producto producto= controller.ObtenerProductoPorNombre(txtNombres.Text);

            if (producto == null)
            {
                MessageBox.Show("El producto no registrado");
            }
            else
            {
                txtProducto_id.Text = producto.ProductoId.ToString();
                txtNombres.Text= producto.NombreProducto;
                txtDescripcion.Text = producto.Descripcion;
                txtPrecio.Text = producto.Precio.ToString();
                txtStock.Text = producto.Stock.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ModificarProducto();
        }
        public void ModificarProducto()
        {
            Producto nuevoProducto = new Producto
            {
                ProductoId = int.Parse(txtProducto_id.Text),
                NombreProducto = txtNombres.Text,
                Descripcion = txtDescripcion.Text,
                Precio = int.Parse(txtPrecio.Text),
                Stock = int.Parse(txtStock.Text),

            };
            //lo mandamos a la base de datos  
            ControllerProductos controller = new ControllerProductos();
            string resultado = controller.ActualizarProducto(nuevoProducto);
            MessageBox.Show(resultado, "Actualizar Producto");
            Limpiar();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarProducto();
        }
        public void EliminarProducto()
        {
            ControllerProductos controller = new ControllerProductos();

            DialogResult resultado = MessageBox.Show("¿Esta seguro de eliminar el registro?", "Confirma eliminiacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (resultado == DialogResult.OK)
            {
                string resul = controller.EliminarProducto(int.Parse(txtProducto_id.Text));
                MessageBox.Show(resul, "Eliminar Pedido");
            }
            Limpiar();
        }

    }
}
