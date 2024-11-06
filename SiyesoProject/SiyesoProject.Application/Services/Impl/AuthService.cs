using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SiyesoProject.Application.Services.Interfaces;
using SiyesoProject.Domain.DTOs;
using SiyesoProject.Domain.Entities;
using SiyesoProject.Infrastructure.DTOs;

namespace SiyesoProject.Application.Services.Impl;

public class AuthService : IAuthService
{
    private readonly UserManager<User> _userManager;
    private readonly IConfiguration _configuration;

    public AuthService(UserManager<User> userManager,IConfiguration configuration)
    {
        _userManager = userManager;
        _configuration = configuration;
    }
    
    public async Task<Response<string>> Login(LoginDto loginDto)
    {
        var user = await _userManager.FindByNameAsync(loginDto.Username);

        if (user == null)
            return Response<string>.Fail("User not found",404);
        var checkPasswordResult = await _userManager.CheckPasswordAsync(user, loginDto.Password);

        if (!checkPasswordResult)
            return Response<string>.Fail("Username or password incorrect",400);

        var jwtToken = CreateJwtToken(user);

        return Response<string>.Success(jwtToken,200);
    }

    public async Task<Response<IdentityResult>> Register(RegisterDto registerDto)
    {
        var user = new User
        {
            UserName = registerDto.Username,
        };
        var result = await _userManager.CreateAsync(user, registerDto.Password);
        if (!result.Succeeded)
            return Response<IdentityResult>.Fail("error",400);
        
        return Response<IdentityResult>.Success(result,200);
    }
    
    public string CreateJwtToken(IdentityUser user)
    {
        //Create claims
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.UserName)
        };

        var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

        var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            issuer: _configuration["Jwt:Issuer"],
            audience: _configuration["Jwt:Audience"],
            claims: claims,
            expires: DateTime.Now.AddMinutes(60),
            signingCredentials: credentials);

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}