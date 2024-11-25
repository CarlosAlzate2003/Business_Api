using System.ComponentModel.DataAnnotations;

namespace ProyectoEF.Data.Models
{
    public class ProveedoresModel
    {
        [Key]
        public Guid IdProveedor { get; set; }

        [Required]
        [MaxLength(150)]
        public string NombreProveedor { get; set; }

        public string? Direccion { get; set; }

        [Required]
        public string Telefono { get; set; }
        public string? Email { get; set; }

        [Required]
        public EstadoEnum estado { get; set; }

        public ICollection<ProductoModel> Productos { get; set; }

    }
}