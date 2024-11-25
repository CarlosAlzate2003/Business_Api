using ProyectoEF.Helpers;
using ProyectoEF.interfaces;
using ProyectoEF.DTOs;
using ProyectoEF.Data.Models;

namespace ProyectoEF.Repositories;

public class AuthRepository : IAuthInterface
{
    private readonly IUsuarioInterface _usuarioRepository;
    private readonly IConfiguration _configuration;

    public AuthRepository(IUsuarioInterface usuarioRepository, IConfiguration configuration)
    {
        _usuarioRepository = usuarioRepository;
        _configuration = configuration;
    }

    public LoginResponseDTO Authenticate(LoginRequestDTO request)
    {
        var usuario = _usuarioRepository.GetUsuario(request.Email);
        if (usuario == null || usuario.PasswordUsuario != request.Password)
        {
            throw new Exception("Usuario o contraseña incorrectos");
        }

        var token = JwtHelper.GenerateJwtToken(usuario.EmailUsuario, _configuration["Jwt:SecretKey"], int.Parse(_configuration["Jwt:ExpireMinutes"]));

        return new LoginResponseDTO
        {
            Token = token,
            Expiration = DateTime.UtcNow.AddMinutes(int.Parse(_configuration["Jwt:ExpireMinutes"]))
        };
    }

}