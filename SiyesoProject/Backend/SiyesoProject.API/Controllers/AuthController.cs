using Microsoft.AspNetCore.Mvc;
using SiyesoProject.Application.Services.Interfaces;
using SiyesoProject.Domain.DTOs;
using SiyesoProject.Infrastructure.Controller;

namespace SiyesoProject.API.Controllers;

public class AuthController : CustomBaseController
{
    private readonly IAuthService _service;
    
    public AuthController(IAuthService service)
    {
        _service = service;
    }

    [HttpPost]
    [Route("login")]
    public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
    {
        var response = await _service.Login(loginDto);
        return CreateActionResultInstance(response);
    }

    [HttpPost]
    [Route("register")]
    public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
    {
        var response = await _service.Register(registerDto);
        return CreateActionResultInstance(response);
    }
}