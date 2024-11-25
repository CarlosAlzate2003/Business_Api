using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoEF.Data.Models
{
    public class VentaModel
    {
        [Key]
        public Guid IdVenta { get; set; }

        [Required]
        public DateTime FechaVenta { get; set; }

        [Required]
        public decimal TotalVenta { get; set; }

        [Required]
        public int CantidadProducto { get; set; }

        public Guid IdProducto { get; set; }

        public Guid IdFactura { get; set; }

        public virtual ProductoModel Producto { get; set; } = null!;
        public virtual FacturaModel Factura { get; set; } = null!;
    }
}