using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda2998601.Model
{
    public class Cliente
    {
        public int ClienteId { get; set; }


        [Required]
        [StringLength(50)]
        public string  Nombres { get; set; }



        [Required]
        [StringLength(12)]
        public string Documento { get; set; }



        [Required]
        [StringLength(50)]
        public string Apellidos { get; set; }


        [Required]
        public string CorreoElectronico { get; set; }



        [Required]
        [StringLength(100)]
        public string Direccion { get; set; }

        public virtual ICollection <Pedido> Pedidos { get; set; }
    }
}
