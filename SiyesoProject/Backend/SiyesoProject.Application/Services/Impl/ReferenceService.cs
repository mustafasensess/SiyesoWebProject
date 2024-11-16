using SiyesoProject.Application.Services.Interfaces;
using SiyesoProject.Domain.Entities;
using SiyesoProject.Infrastructure.DTOs;
using SiyesoProject.Persistence.Repository.Interfaces;

namespace SiyesoProject.Application.Services.Impl;

public class ReferenceService : IReferenceService
{
    private readonly IReferenceRepository _repository;

    public ReferenceService(IReferenceRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<Response<List<Reference>>> GetAll()
    {
        var references = await _repository.GetAll();
        return Response<List<Reference>>.Success(references, 200);
    }

    public async Task<Response<Reference>> Delete(Reference? reference)
    {
        if (reference == null)
        {
            return Response<Reference>.Fail("Not Found", 404);
        }

        await _repository.Delete(reference);
        return Response<Reference>.Success(reference, 200);
    }

    public async Task<Response<Reference>> Update(Reference? reference)
    {
        if (reference == null)
        {
            return Response<Reference>.Fail("Not Found", 404);
        }

        await _repository.Update(reference);
        return Response<Reference>.Success(reference, 200);
    }

    public async Task<Response<Reference>> Create(Reference? reference)
    {
        if (reference == null)
        {
            return Response<Reference>.Fail("Not Found", 404);
        }

        await _repository.Create(reference);
        return Response<Reference>.Success(reference, 200);
    }
}