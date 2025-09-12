using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tienda2998601.VIew;

namespace tienda2998601
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //creamos la instancia del formmulario llamandolo 
            FrmClientes formularioClientes = new FrmClientes();

            //asignamos un padre al formulario
            formularioClientes.MdiParent = this;

            //cargamos o mostramos el formulario  en la vista principal
            formularioClientes.Show();


        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //creamos la instancia del formmulario llamandolo 
            FrmProductos formularioProductos = new FrmProductos();

            //asignamos un padre al formulario
            formularioProductos.MdiParent = this;

            //cargamos o mostramos el formulario  en la vista principal
            formularioProductos.Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void gestionarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //creamos la instancia del formmulario llamandolo 
            FrmPedido GUIPedido = new FrmPedido();

            //asignamos un padre al formulario
            GUIPedido.MdiParent = this;

            //cargamos o mostramos el formulario  en la vista principal
            GUIPedido.Show();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
