using Microsoft.AspNetCore.Mvc;
using ProyectoEF.DTOs;
using ProyectoEF.interfaces;


namespace ProyectoEF.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthInterface _authRepository;

    public AuthController(IAuthInterface authRepository)
    {
        _authRepository = authRepository;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequestDTO request)
    {
        try
        {
            var response = _authRepository.Authenticate(request);
            return Ok(response);
        }
        catch (UnauthorizedAccessException)
        {
            return Unauthorized("Invalid credentials");
        }
    }
}