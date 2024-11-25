using System.ComponentModel.DataAnnotations;

namespace ProyectoEF.Data.Models
{
    public class ClienteModel
    {
        [Key]
        public Guid IdCliente { get; set; }
        public string? CedulaCliente { get; set; }
        [Required]
        [MaxLength(150)]
        public string NombreCliente { get; set; }
        public string? DireccionCliente { get; set; }
        public string TelefonoCliente { get; set; }
        public string? EmailCliente { get; set; }

        public ICollection<FacturaModel> Facturas { get; set; }
    }
}