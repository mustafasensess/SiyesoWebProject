using Microsoft.AspNetCore.Identity;
using SiyesoProject.Domain.DTOs;
using SiyesoProject.Domain.Entities;
using SiyesoProject.Infrastructure.DTOs;

namespace SiyesoProject.Application.Services.Interfaces;

public interface IAuthService
{
    public Task<Response<string>> Login(LoginDto loginDto);

    public Task<Response<IdentityResult>> Register(RegisterDto registerDto);
}