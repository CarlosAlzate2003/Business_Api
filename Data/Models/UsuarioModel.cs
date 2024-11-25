using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoEF.Data.Models
{
    public class UsuarioModel
    {
        [Key]
        public Guid IdUsuario { get; set; }

        [Required]
        [MaxLength(50)]
        public string NombreUsuario { get; set; }

        public string? CedulaUsuario { get; set; }

        [Required]
        [MaxLength(50)]
        public string EmailUsuario { get; set; }

        [Required]
        [MaxLength(50)]
        public string PasswordUsuario { get; set; }

        public Guid IdRol { get; set; }

        [Required]
        public EstadoEnum estado { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }

        public virtual RolModel Rol { get; set; }

        public ICollection<FacturaModel> Facturas { get; set; }
    }
}

public enum EstadoEnum
{
    Activo = 1,
    Inactivo = 2
}