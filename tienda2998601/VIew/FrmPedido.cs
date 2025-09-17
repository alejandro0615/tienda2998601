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
    public partial class FrmPedido : Form
    {
        //objetos globales para usar distintos controladores

        ControllerClientes controllerClientes = new ControllerClientes();
        ControllerProductos controllerProductos = new ControllerProductos();
        ControllerPedidos controllerPedidos = new ControllerPedidos();
        ControllerDetallesPedido controllerDetallesPedidos = new ControllerDetallesPedido();
        Pedido pedido = null;
        Cliente cliente = null;
        int pedidoId = 0;
        int posCliente = -1;
        List<Cliente> lstClientes = new List<Cliente>();
        List<Producto> lstProducto = new List<Producto>();
        List<ProductoSeleccionado> lstProductoSeleccionados = new List<ProductoSeleccionado>();


        public FrmPedido()
        {
            InitializeComponent();
            lstClientes = controllerClientes.ObtenerTodoslosClientes();
            cargarClientes();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            crearPedido();
        }
        private void crearPedido() 
        {
            gbProductos.Enabled = true;
            pedido = new Pedido();
            //obtener todos los clientes especificos
            cliente = controllerClientes.ObtenerClientePorDocumento(lstClientes[posCliente].Documento);

            //validamos que este capturando bien 
            //MessageBox.Show(cliente.ClienteId.ToString() +" "+ cliente.Documento);

            pedido.ClienteId = cliente.ClienteId;
            pedido.FechaPedido = dtpFecha.Value.Date;
            pedido.Estado=cbxEstado.SelectedItem.ToString();

            //validamos que este capturando bien
            //MessageBox.Show(pedido.Estado);

            pedidoId = controllerPedidos.agregarPedido(pedido);

            //validamos que este retornando bien el id del pedido
            //MessageBox.Show(pedidoId.ToString());



        }
        private void cargarClientes()
        {
            //lstClientes = controllerClientes.ObtenerTodoslosClientes();
            foreach (Cliente c in lstClientes) 
            {
                cbxClientes.Items.Add(c.Nombres + " " +c.Apellidos);
            }
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            //cargarClientes();
            CargarProductos();
        }

        private void cbxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            posCliente = cbxClientes.SelectedIndex;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            agregarProducto();
        }
        private void agregarProducto() 
        {
            if (cbxProducto.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtCantidad.Text)) 
            {
                MessageBox.Show("seleccione por favor un producto valido y la cantidad ");
                return;
            }
            var nombre = cbxProducto.SelectedItem.ToString();
            var producto = lstProducto.FirstOrDefault(p => p.NombreProducto == nombre);
            var cantidad = int.Parse(txtCantidad.Text);

            if (cantidad > producto.Stock)
            {
                MessageBox.Show("lo lamentamos la cantidad supera a lo que hay en el Stock");
                return;
            }

            var existe = lstProductoSeleccionados.FirstOrDefault(p => p.ProductoId == producto.ProductoId);

            if (existe != null)
            {
                if (existe.Cantidad + cantidad > producto.Stock)
                {
                    MessageBox.Show("lo lamentamos la cantidad supera a lo que hay en el Stock");
                }
                else
                {
                    existe.Cantidad += cantidad;
                }
            }
            else
            {
                lstProductoSeleccionados.Add(new ProductoSeleccionado
                {
                    ProductoId = producto.ProductoId,
                    Nombre = producto.NombreProducto,
                    Cantidad = cantidad,
                    PrecioUnitario = producto.Precio

                }
                );
            }
            actualizarGrid();
            actualizarTotalPedido();
        }
        private void CargarProductos() 
        {
            lstProducto = controllerProductos.ObtenerTodoslosProductos();
            cbxProducto.Items.Clear();
            foreach (Producto p in lstProducto)
            {
                cbxProducto.Items.Add(p.NombreProducto);
            }
        }
        private void actualizarGrid()
        {
            dtvProductos.DataSource = null;
            dtvProductos.DataSource = lstProductoSeleccionados;
        }
        private void actualizarTotalPedido() 
        {
            decimal total = lstProductoSeleccionados.Sum(p => p.Subtotal);
            lblTotal.Text = $"Total: {total.ToString()}";
        }
        private void finalizarPedido() 
        {
            if (lstProductoSeleccionados.Count == 0) 
            {
                MessageBox.Show("Debe agregar al menos un producto...");
                return;
            }
            decimal totalPedido = 0;
            foreach (var p in lstProductoSeleccionados) 
            {
                var productoEnBD= controllerProductos.ObtenerProductoPorId(p.ProductoId);
                if (productoEnBD.Stock < p.Cantidad)
                {
                    MessageBox.Show($"No hay suficiente Stock para el producto: {productoEnBD.NombreProducto}");
                }
            }
            //si todos los productos tienen stock se pueden llevar los detalles a la BD
            foreach (var p in lstProductoSeleccionados) 
            {
                var detalle = new DetallePedido
                {
                    PedidoId = pedidoId,
                    ProductoId=p.ProductoId,
                    Cantidad = p.Cantidad,
                    PrecioUnitario= (int)p.PrecioUnitario
                };

                controllerDetallesPedidos.AgregarDetalles(detalle);
                totalPedido += p.Subtotal;

                //falta actualizar el stock de productos!!!!!!!!
                //hacerlo en el controlador de productos
                
                controllerProductos.actualizarStock(p.ProductoId, p.Cantidad);
            }
            //actualizar el total del pedido
            pedido.TotalPedido = totalPedido;
            pedido.PedidoId=pedidoId;
            controllerPedidos.ActualizarPedido(pedido);

            lblTotal.Text = $"total: {totalPedido:c}";
            MessageBox.Show("Pedido realizado correctamente");
            limpiar();
        }
        public void limpiar() 
        {
            cbxClientes.SelectedIndex = -1;
            cbxProducto.SelectedIndex=-1;
            txtCantidad.Clear();
            lstProductoSeleccionados.Clear();
            actualizarGrid();
            lblTotal.Text = "Total: $00.00  ";
            gbProductos.Enabled = false;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            finalizarPedido();
        }
    }
}
