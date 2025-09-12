using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tienda2998601.Model;

namespace tienda2998601.Controller
{
    public class ControllerPedidos
    {
        private readonly Tienda2998601Context _context;

        public ControllerPedidos()
        {
            _context = new Tienda2998601Context();
        }
        public Pedido ObtenerPedidoPorId(int id)
        {
            return _context.Pedidos
                           .Include(p => p.Cliente)
                           .FirstOrDefault(p => p.PedidoId == id);
        }

        public List<Pedido> ObtenerTodoslosPedidos()
        {
            return _context.Pedidos.ToList();
        }

        public int agregarPedido(Pedido pedido)
        {
            try
            {
                _context.Pedidos.Add(pedido);
                _context.SaveChanges();
                return pedido.PedidoId;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
        public string ActualizarPedido(Pedido pedido)
        {
            var PedidoExistente = _context.Pedidos.Find(pedido.PedidoId);
            if (PedidoExistente != null)
            {
                try
                {
                    
                    PedidoExistente.ClienteId = pedido.ClienteId;
                    PedidoExistente.FechaPedido = pedido.FechaPedido;
                    PedidoExistente.Estado = pedido.Estado;
                    PedidoExistente.TotalPedido = pedido.TotalPedido;
                    
                    _context.SaveChanges();
                   
                    return "El pedido ha sido ACtualizado Correctamente....";
                }
                catch (SqlException ex)
                {
                    return $"Error en la base de datos: {ex.Message}";
                }
                catch (Exception ex)
                {
                    return $"Ocurrio un error inesperado: {ex.Message}";
                }

            }
            return "el pedido no ha sido registrado...";
        }
        public string EliminarPedido(int id)
        {
            var pedido = _context.Pedidos.Find(id);
            if (pedido != null)
            {
                try
                {
                    _context.Pedidos.Remove(pedido);
                    _context.SaveChanges();
                    return "el Pedido a sido eliminado correctamente";
                }
                catch (SqlException ex)
                {
                    return $"Error en la base de datos: {ex.Message}";
                }
                catch (Exception ex)
                {
                    return $"Ocurrio un error inesperado: {ex.Message}";
                }
            }
            return "El Pedido no ha sido registrado...";
        }
    }
}
