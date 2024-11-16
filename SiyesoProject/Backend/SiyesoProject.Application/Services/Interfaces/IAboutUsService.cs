using SiyesoProject.Domain.Entities;
using SiyesoProject.Infrastructure.DTOs;

namespace SiyesoProject.Application.Services.Interfaces;

public interface IAboutUsService
{
    public Task<Response<List<AboutUs>>> GetAll();

    public Task<Response<AboutUs>> Delete(AboutUs? aboutUs);
    
    public Task<Response<AboutUs>> Update(AboutUs? aboutUs);
    
    public Task<Response<AboutUs>> Create(AboutUs? aboutUs);
    
}