using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tienda2998601.Model;

namespace tienda2998601.Controller
{
    public class ControllerClientes
    {
        private readonly Tienda2998601Context _context;

        public ControllerClientes() 
        {
            _context = new Tienda2998601Context();
        }

        public Cliente ObtenerClientePorId(int id) 
        {
            return _context.Clientes.Find(id);
        }
        public Cliente ObtenerClientePorNombreAp(String nombre, string apellido) 
        {
            return _context.Clientes.FirstOrDefault(c => c.Nombres == nombre && c.Apellidos ==apellido );
        }
        public List<Cliente> ObtenerTodoslosClientes() 
        {
            return _context.Clientes.ToList();
        }

        public Cliente ObtenerClientePorDocumento(string doc) 
        {
            return _context.Clientes.FirstOrDefault(c => c.Documento == doc);
        }

        public string agregarCliente(Cliente cliente) 
        {
            try
            {
                _context.Clientes.Add(cliente);
                _context.SaveChanges();
                return "el cliente a sido agregado con exito";

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
        public string ActualizarCliente(Cliente cliente) 
        {
            var clienteExistente = _context.Clientes.Find(cliente.ClienteId);
            if (clienteExistente != null) 
            {
                try
                {
                    clienteExistente.Nombres = cliente.Nombres;
                    clienteExistente.Documento = cliente.Documento;
                    clienteExistente.Apellidos = cliente.Apellidos;
                    clienteExistente.CorreoElectronico = cliente.CorreoElectronico;
                    clienteExistente.Direccion = cliente.Direccion;
                    _context.SaveChanges();
                    return "El cliente ha sido ACtualizado....";
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
            return "el cliente no ha sido registrado...";
        }
        public string EliminarCliente(int id) 
        {
            var cliente = _context.Clientes.Find(id);
            if (cliente != null) 
            {
                try 
                {
                    _context.Clientes.Remove(cliente);
                    _context.SaveChanges();
                    return "el cliente a sido eliminado correctamente";
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
            return "cliente no ha sido registrado...";
        }
    }
}
