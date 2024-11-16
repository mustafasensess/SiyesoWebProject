using SiyesoProject.Application.Services.Interfaces;
using SiyesoProject.Domain.Entities;
using SiyesoProject.Infrastructure.DTOs;
using SiyesoProject.Persistence.Repository.Interfaces;

namespace SiyesoProject.Application.Services.Impl;

public class AboutUsService : IAboutUsService
{
    private readonly IAboutUsRepository _repository;

    public AboutUsService(IAboutUsRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<Response<List<AboutUs>>> GetAll()
    {
        return Response<List<AboutUs>>.Success(await _repository.GetAll(), 200);
    }

    public async Task<Response<AboutUs>> Delete(AboutUs? aboutUs)
    {
        if (aboutUs == null)
        {
            return Response<AboutUs>.Fail("Not Found", 404);
        }

        await _repository.Delete(aboutUs);
        return Response<AboutUs>.Success(aboutUs, 200);
    }

    public async Task<Response<AboutUs>> Update(AboutUs? aboutUs)
    {
        if (aboutUs == null)
        {
            return Response<AboutUs>.Fail("Not Found", 404);
        }

        await _repository.Update(aboutUs);
        return Response<AboutUs>.Success(aboutUs, 200);
    }

    public async Task<Response<AboutUs>> Create(AboutUs? aboutUs)
    {
        if (aboutUs == null)
        {
            return Response<AboutUs>.Fail("Not Found", 404);
        }

        await _repository.Create(aboutUs);
        return Response<AboutUs>.Success(aboutUs, 200);
    }
}