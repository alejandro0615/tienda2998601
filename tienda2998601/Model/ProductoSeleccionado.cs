using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda2998601.Model
{
    public class ProductoSeleccionado
    {


        public int ProductoId { get; set; }

        
        public string Nombre { get; set; }


        public int Cantidad { get; set; }


        public decimal PrecioUnitario { get; set; }


        public decimal Subtotal => Cantidad * PrecioUnitario;
        
    }
}
