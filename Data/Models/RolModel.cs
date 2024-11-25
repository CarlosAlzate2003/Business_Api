using System.ComponentModel.DataAnnotations;

namespace ProyectoEF.Data.Models
{
    public class RolModel
    {
        [Key]
        public Guid IdRol { get; set; }

        [Required]
        [MaxLength(150)]
        public string NombreRol { get; set; }

        public ICollection<UsuarioModel> Usuarios { get; set; }
    }
}
