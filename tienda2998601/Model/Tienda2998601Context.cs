using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda2998601.Model
{
    public class Tienda2998601Context:DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<DetallePedido> DetallePedidos { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                //un indice (HasIndex) es una restriccion en base de datos
                .HasIndex(c => c.CorreoElectronico)
                .IsUnique();
            
            modelBuilder.Entity<Cliente>()
                //un indice (HasIndex) es una restriccion en base de datos
                .HasIndex(c => c.Documento)
                .IsUnique();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //aca se crea la cadena de conexion 
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-JTDD74O\SQLEXPRESS; Database=tienda2998601; trusted_Connection=true");
        }
    }
}
