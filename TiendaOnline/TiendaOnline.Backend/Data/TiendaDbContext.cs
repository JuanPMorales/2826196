using Microsoft.EntityFrameworkCore;
using TiendaOnline.API.Models;

namespace TiendaOnline.API.Data
{
    /// <summary>
    /// Contexto de la base de datos para la tienda en línea.
    /// </summary>
    public class TiendaDbContext : DbContext
    {
        /// <summary>
        /// Constructor del contexto que recibe opciones de configuración.
        /// </summary>
        /// <param name="options">Opciones de configuración del contexto</param>
        public TiendaDbContext(DbContextOptions<TiendaDbContext> options) : base(options)
        {
        }

        // Definir las tablas de la base de datos (DbSets)
        public DbSet<Cliente> Clientes { get; set; }
        //public DbSet<Proveedor> Proveedores { get; set; }
        //public DbSet<Producto> Productos { get; set; }
        //public DbSet<Venta> Ventas { get; set; }
        //public DbSet<DetalleVenta> DetalleVentas { get; set; }
        //public DbSet<Compra> Compras { get; set; }
        //public DbSet<DetalleCompra> DetalleCompras { get; set; }

        /// <summary>
        /// Configuración adicional del modelo de base de datos.
        /// </summary>
        /// <param name="modelBuilder">Constructor del modelo</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurar relaciones en la base de datos usando Fluent API
            //modelBuilder.Entity<Cliente>()
            //    .HasMany(c => c.Ventas)
            //    .WithOne(v => v.Cliente)
            //    .HasForeignKey(v => v.IdCliente);

            //modelBuilder.Entity<Proveedor>()
            //    .HasMany(p => p.Compras)
            //    .WithOne(c => c.Proveedor)
            //    .HasForeignKey(c => c.IdProveedor);

            //modelBuilder.Entity<Venta>()
            //    .HasMany(v => v.DetalleVentas)
            //    .WithOne(dv => dv.Venta)
            //    .HasForeignKey(dv => dv.IdVenta);

            //modelBuilder.Entity<Compra>()
            //    .HasMany(c => c.DetalleCompras)
            //    .WithOne(dc => dc.Compra)
            //    .HasForeignKey(dc => dc.IdCompra);

            //modelBuilder.Entity<DetalleVenta>()
            //    .HasOne(dv => dv.Producto)
            //    .WithMany(p => p.DetalleVentas)
            //    .HasForeignKey(dv => dv.IdProducto);

            //modelBuilder.Entity<DetalleCompra>()
            //    .HasOne(dc => dc.Producto)
            //    .WithMany(p => p.DetalleCompras)
            //    .HasForeignKey(dc => dc.IdProducto);
        }
    }
}
