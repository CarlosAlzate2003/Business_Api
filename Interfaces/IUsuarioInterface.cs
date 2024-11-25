using ProyectoEF.Data.Models;

namespace ProyectoEF.interfaces;

public interface IUsuarioInterface
{
    public UsuarioModel GetUsuario(string email);
}