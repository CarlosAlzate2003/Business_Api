using ProyectoEF.DTOs;

namespace ProyectoEF.interfaces;

public interface IAuthInterface
{
    public LoginResponseDTO Authenticate(LoginRequestDTO request);
}