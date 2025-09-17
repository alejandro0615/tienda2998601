using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tienda2998601.Model;

namespace tienda2998601.Controller
{
    public class ControllerProductos
    {
        private readonly Tienda2998601Context _context;
        public ControllerProductos()
        {
            _context = new Tienda2998601Context();
        }
        public Producto ObtenerProductoPorNombre(string nombre)
        {
            return _context.Productos.FirstOrDefault(c => c.NombreProducto == nombre);
        }
        public List<Producto> ObtenerTodoslosProductos()
        {
            return _context.Productos.ToList();
        }
        public Producto ObtenerProductoPorId(int id)
        {
            return _context.Productos.Find(id);
        }
        public string agregarProducto(Producto producto)
        {
            try
            {
                _context.Productos.Add(producto);
                _context.SaveChanges();
                return "El producto ha sido agregado con exito";
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
        public string ActualizarProducto(Producto producto)
        {
            var productoExiste = _context.Productos.Find(producto.ProductoId);
            if (productoExiste != null)
            {
                try
                {
                    productoExiste.NombreProducto = producto.NombreProducto;
                    productoExiste.Descripcion = producto.Descripcion;
                    productoExiste.Precio = producto.Precio;
                    productoExiste.Stock = producto.Stock;
                    _context.SaveChanges();
                    return "El Producto se ha modificado!!";
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
            return "El producto No ha sido registrado!!";
        }
        public string EliminarProducto(int id)
        {
            var producto = _context.Productos.Find(id);
            if (producto != null)
            {
                try
                {
                    _context.Productos.Remove(producto);
                    _context.SaveChanges();
                    return "El producto ha sido eliminado correctamente";
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
            return "El Producto no ha sido registrado";
        }

        public string actualizarStock(int productoId, int cantidadVendida)
        {
            var producto = _context.Productos.Find(productoId);
            if (producto == null)
            {
                return "producto no encontrado";
            }
            if (producto.Stock < cantidadVendida)
            {
                return $"stock insuficiente para el producto'{producto.NombreProducto}' " +
                    $"stock actual '{producto.Stock}' cantidad solicitada '{cantidadVendida}'";
            }
            try
            {
                producto.Stock -= cantidadVendida;
                _context.SaveChanges();
                return $"Stock actualizado con exito, cantidad restante: '{producto.Stock}'";
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
        public string agregarStock(int productoId, int cantidadVendida)
        {
            var producto = _context.Productos.Find(productoId);
            if (producto != null)
            {
                return "producto no encontrado";
            }
            try
            {
                producto.Stock += cantidadVendida;
                _context.SaveChanges();
                return $"Stock actualizado con exito, cantidad en el momento: '{producto.Stock}'";
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

    }
}
