using SiyesoProject.Application.Services.Interfaces;
using SiyesoProject.Domain.Entities;
using SiyesoProject.Infrastructure.DTOs;
using SiyesoProject.Persistence.Repository.Impl;
using SiyesoProject.Persistence.Repository.Interfaces;

namespace SiyesoProject.Application.Services.Impl;

public class SpecialtyService : ISpecialtyService
{
    private readonly ISpecialtiesRepository _repository;

    public SpecialtyService(ISpecialtiesRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<Response<List<Specialty>>> GetAll()
    {
        var specialties = await _repository.GetAll();
        return Response<List<Specialty>>.Success(specialties, 200);
    }

    public async Task<Response<Specialty>> Delete(Specialty? specialty)
    {
        if (specialty == null)
        {
            return Response<Specialty>.Fail("Not Found", 404);
        }
        await _repository.Delete(specialty);
        return Response<Specialty>.Success(specialty, 200);
    }

    public async Task<Response<Specialty>> Update(Specialty? specialty)
    {
        if (specialty == null)
        {
            return Response<Specialty>.Fail("Not Found", 404);
        }

        await _repository.Update(specialty);
        return Response<Specialty>.Success(specialty, 200);
    }

    public async Task<Response<Specialty>> Create(Specialty? specialty)
    {
        if (specialty == null)
        {
            return Response<Specialty>.Fail("Not Found", 404);
        }
        await _repository.Create(specialty);
        return Response<Specialty>.Success(specialty, 200);
    }
}