using SiyesoProject.Domain.Entities;
using SiyesoProject.Infrastructure.DTOs;

namespace SiyesoProject.Application.Services.Interfaces;

public interface IReferenceService
{
    public Task<Response<List<Reference>>> GetAll();

    public Task<Response<Reference>> Delete(Reference? reference);

    public Task<Response<Reference>> Update(Reference? reference);

    public Task<Response<Reference>> Create(Reference? reference);
}