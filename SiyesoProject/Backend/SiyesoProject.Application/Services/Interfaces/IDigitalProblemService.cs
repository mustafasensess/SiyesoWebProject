using SiyesoProject.Domain.Entities;
using SiyesoProject.Infrastructure.DTOs;

namespace SiyesoProject.Application.Services.Interfaces;

public interface IDigitalProblemService
{
    public Task<Response<List<DigitalProblem>>> GetAll();

    public Task<Response<DigitalProblem>> Delete(DigitalProblem? digitalProblem);

    public Task<Response<DigitalProblem>> Update(DigitalProblem? digitalProblem);

    public Task<Response<DigitalProblem>> Create(DigitalProblem? digitalProblem);
    
}