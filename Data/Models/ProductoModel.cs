using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoEF.Data.Models
{
    public class ProductoModel
    {
        [Key]
        public Guid IdProducto { get; set; }

        [Required]
        [MaxLength(150)]
        public string NombreProducto { get; set; }
        public string? DescripcionProducto { get; set; }

        [Required]
        public int CantidadProducto { get; set; }
        [Required]
        public decimal PrecioProducto { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }

        public Guid IdProveedor { get; set; }

        [ForeignKey("CategoriaId")]
        public Guid IdCategoria { get; set; }

        public virtual ProveedoresModel Proveedor { get; set; }

        public virtual ICollection<VentaModel> Venta { get; set; }

        public virtual CategoriaProductoModels Categoria { get; set; }
    }
}