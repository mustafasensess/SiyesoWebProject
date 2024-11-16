using Microsoft.EntityFrameworkCore;
using SiyesoProject.Application.Services.Interfaces;
using SiyesoProject.Domain.Entities;
using SiyesoProject.Infrastructure.DTOs;
using SiyesoProject.Persistence.Context;
using SiyesoProject.Persistence.Repository.Interfaces;

namespace SiyesoProject.Application.Services.Impl;

public class DigitalProblemService : IDigitalProblemService
{
    private readonly IDigitalProblemsRepository _repository;

    public DigitalProblemService(IDigitalProblemsRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<Response<List<DigitalProblem>>> GetAll()
    {
        return Response<List<DigitalProblem>>.Success(await _repository.GetAll(), 200);
    }

    public async Task<Response<DigitalProblem>> Delete(DigitalProblem? digitalProblem)
    {
        if (digitalProblem == null)
        {
            return Response<DigitalProblem>.Fail("Not Found", 404);
        }

        await _repository.Delete(digitalProblem);
        return Response<DigitalProblem>.Success(digitalProblem, 200);
    }

    public async Task<Response<DigitalProblem>> Update(DigitalProblem? digitalProblem)
    {
        if (digitalProblem == null)
        {
            return Response<DigitalProblem>.Fail("Not found", 404);
        }

        await _repository.Update(digitalProblem);
        return Response<DigitalProblem>.Success(digitalProblem, 200);
    }

    public async Task<Response<DigitalProblem>> Create(DigitalProblem? digitalProblem)
    {
        if (digitalProblem == null)
        {
            return Response<DigitalProblem>.Fail("Not found", 404);
        }

        await _repository.Create(digitalProblem);
        return Response<DigitalProblem>.Success(digitalProblem, 200);
    }
}