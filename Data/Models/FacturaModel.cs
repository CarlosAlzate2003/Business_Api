using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoEF.Data.Models
{
    public class FacturaModel
    {
        [Key]
        public Guid IdFactura { get; set; }

        [Required]
        public DateTime FechaFactura { get; set; }

        [Required]
        public decimal TotalFactura { get; set; }

        [Required]
        public int CantidadTotalProductos { get; set; }

        [ForeignKey("CategoriaId")]
        public Guid idUsuario { get; set; }

        [ForeignKey("ClienteId")]
        public Guid IdCliente { get; set; }

        public virtual UsuarioModel Usuario { get; set; }

        public virtual ICollection<VentaModel> Venta { get; set; }

        public virtual ClienteModel Cliente { get; set; }
    }
}