using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda2998601.Model
{
    public class Producto
    {
        public int ProductoId { get; set; }

        [Required]
        [StringLength(50)]
        public string NombreProducto { get; set; }


        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }

        [Required]        
        public int Precio { get; set; }

        [Required]
        public int Stock { get; set; }
        public virtual ICollection<DetallePedido> DetallePedidos { get; set; }
    }
}
