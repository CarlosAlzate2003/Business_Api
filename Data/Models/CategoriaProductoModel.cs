using System.ComponentModel.DataAnnotations;

namespace ProyectoEF.Data.Models
{
    public class CategoriaProductoModels
    {
        [Key]
        public Guid IdCategoriaProducto { get; set; }

        [Required]
        [MaxLength(150)]
        public string NombreCategoria { get; set; }
        public string? Descripcion { get; set; }

        public ICollection<ProductoModel> Producto { get; set; }
    }
}