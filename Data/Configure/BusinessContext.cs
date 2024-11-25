using Microsoft.EntityFrameworkCore;
using ProyectoEF.Data.Models;

namespace ProyectoEF;

public class BusinessContext : DbContext
{
    public DbSet<RolModel> Rol { get; set; }
    public DbSet<UsuarioModel> Usuario { get; set; }

    public DbSet<CategoriaProductoModels> CategoriaProducto { get; set; }

    public DbSet<ProveedoresModel> Proveedores { get; set; }

    public DbSet<ProductoModel> Producto { get; set; }

    public DbSet<ClienteModel> Cliente { get; set; }

    public DbSet<FacturaModel> Factura { get; set; }

    public DbSet<VentaModel> Venta { get; set; }

    public BusinessContext(DbContextOptions<BusinessContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RolModel>(rol =>
        {
            rol.ToTable("Rol");
            rol.HasKey(p => p.IdRol);
            rol.Property(p => p.IdRol).HasColumnName("IdRol");
            rol.Property(p => p.NombreRol).HasColumnName("Nombre");
        });

        modelBuilder.Entity<UsuarioModel>(usuario =>
        {
            usuario.ToTable("Usuario");
            usuario.HasKey(p => p.IdUsuario);
            usuario.Property(p => p.IdUsuario).HasColumnName("IdUsuario");
            usuario.Property(p => p.NombreUsuario).HasColumnName("Nombre");
            usuario.Property(p => p.CedulaUsuario).HasColumnName("Cedula");
            usuario.Property(p => p.EmailUsuario).HasColumnName("Correo");
            usuario.Property(p => p.PasswordUsuario).HasColumnName("Contrasena");
            usuario.HasOne(p => p.Rol).WithMany(p => p.Usuarios).HasForeignKey(p => p.IdRol);
            usuario.Property(p => p.estado).HasColumnName("estado");
            usuario.Property(p => p.FechaCreacion).HasColumnName("FechaCreacion");
        });

        modelBuilder.Entity<ProveedoresModel>(Proveedor =>
        {
            Proveedor.ToTable("Proveedores");
            Proveedor.HasKey(p => p.IdProveedor);
            Proveedor.Property(p => p.IdProveedor).HasColumnName("IdProveedor");
            Proveedor.Property(p => p.NombreProveedor).HasColumnName("Nombre");
            Proveedor.Property(p => p.Direccion).HasColumnName("Direccion");
            Proveedor.Property(p => p.Telefono).HasColumnName("Telefono");
            Proveedor.Property(p => p.Email).HasColumnName("Email");
            Proveedor.Property(p => p.estado).HasColumnName("Estado");
        });

        modelBuilder.Entity<CategoriaProductoModels>(CategoriaProducto =>
        {
            CategoriaProducto.ToTable("CategoriaProducto");
            CategoriaProducto.HasKey(p => p.IdCategoriaProducto);
            CategoriaProducto.Property(p => p.IdCategoriaProducto).HasColumnName("IdCategoria");
            CategoriaProducto.Property(p => p.NombreCategoria).HasColumnName("Nombre");
            CategoriaProducto.Property(p => p.Descripcion).HasColumnName("Descripcion");
        });

        modelBuilder.Entity<ProductoModel>(Producto =>
        {
            Producto.ToTable("Producto");
            Producto.HasKey(p => p.IdProducto);
            Producto.Property(p => p.IdProducto).HasColumnName("IdProducto");
            Producto.Property(p => p.NombreProducto).HasColumnName("Nombre");
            Producto.Property(p => p.DescripcionProducto).HasColumnName("Descripcion");
            Producto.Property(p => p.CantidadProducto).HasColumnName("Cantidad");
            Producto.Property(p => p.PrecioProducto).HasColumnName("Precio");
            Producto.HasOne(p => p.Categoria).WithMany(p => p.Producto).HasForeignKey(p => p.IdCategoria);
            Producto.HasOne(p => p.Proveedor).WithMany(p => p.Productos).HasForeignKey(p => p.IdProveedor);
        });

        modelBuilder.Entity<ClienteModel>(Cliente =>
        {
            Cliente.ToTable("Cliente");
            Cliente.HasKey(p => p.IdCliente);
            Cliente.Property(p => p.IdCliente).HasColumnName("IdCliente");
            Cliente.Property(p => p.NombreCliente).HasColumnName("Nombre");
            Cliente.Property(p => p.DireccionCliente).HasColumnName("Direccion");
            Cliente.Property(p => p.TelefonoCliente).HasColumnName("Telefono");
            Cliente.Property(p => p.EmailCliente).HasColumnName("Email");
        });

        modelBuilder.Entity<FacturaModel>(Factura =>
        {
            Factura.ToTable("Factura");
            Factura.HasKey(p => p.IdFactura);
            Factura.Property(p => p.IdFactura).HasColumnName("IdFactura");
            Factura.Property(p => p.FechaFactura).HasColumnName("FechaFactura");
            Factura.Property(p => p.TotalFactura).HasColumnName("TotalFactura");
            Factura.HasOne(p => p.Cliente).WithMany(p => p.Facturas).HasForeignKey(p => p.IdCliente);
            Factura.HasOne(p => p.Usuario).WithMany(p => p.Facturas).HasForeignKey(p => p.idUsuario);
        });

        modelBuilder.Entity<VentaModel>(Venta =>
        {
            Venta.ToTable("Venta");
            Venta.HasKey(p => p.IdVenta);
            Venta.Property(p => p.IdVenta).HasColumnName("IdVenta");
            Venta.Property(p => p.CantidadProducto).HasColumnName("CantidadVenta");
            Venta.Property(p => p.TotalVenta).HasColumnName("TotalVenta");
            Venta.HasOne(p => p.Producto).WithMany(p => p.Venta).HasForeignKey(p => p.IdProducto);
            Venta.HasOne(p => p.Factura).WithMany(p => p.Venta).HasForeignKey(p => p.IdFactura);
        });




    }
}