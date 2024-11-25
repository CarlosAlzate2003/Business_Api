using Microsoft.AspNetCore.Mvc;
using ProyectoEF.DTOs;
using ProyectoEF.interfaces;

namespace ProyectoEF.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsuarioController : ControllerBase
{
    private readonly IUsuarioInterface _usuarioRepository;

    public UsuarioController(IUsuarioInterface usuarioRepository)
    {
        _usuarioRepository = usuarioRepository;
    }

    [HttpPost("registrar")]
    public async Task<ActionResult<string>> Registrar(RegistroRequestDTO usuarioRegistroDto)
    {
        return "hola";
    }
}