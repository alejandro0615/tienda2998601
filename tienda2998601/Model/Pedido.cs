using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda2998601.Model
{
    public class Pedido
    {
        public int PedidoId { get; set; }

        [Required]
        public int ClienteId { get; set; }


        [Required]
        public DateTime FechaPedido { get; set; }


        [Required]
        [StringLength(20)]
        public string Estado { get; set; }


        [Required]
        public decimal TotalPedido { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual ICollection<DetallePedido> DetallePedidos { get; set; }
    }
}
