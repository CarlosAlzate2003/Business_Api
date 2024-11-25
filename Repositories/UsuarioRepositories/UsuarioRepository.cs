using ProyectoEF.Data.Models;
using ProyectoEF.Data;
using ProyectoEF.interfaces;

namespace ProyectoEF.Repositories;

public class UsuarioRepository : IUsuarioInterface
{
    private readonly BusinessContext _context;

    public UsuarioRepository(BusinessContext context)
    {
        _context = context;
    }

    public UsuarioModel GetUsuario(string email)
    {
        return _context.Usuario.FirstOrDefault(u => u.EmailUsuario == email);
    }
}