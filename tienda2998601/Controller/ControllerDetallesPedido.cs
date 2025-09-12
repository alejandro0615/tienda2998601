using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tienda2998601.Model;

namespace tienda2998601.Controller
{
    public class ControllerDetallesPedido
    {
        private readonly Tienda2998601Context _context;
        public ControllerDetallesPedido()
        {
            _context = new Tienda2998601Context();
        }
        public void AgregarDetalles(DetallePedido detalle) 
        {
            try 
            {
                _context.DetallePedidos.Add(detalle);
                _context.SaveChanges();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
