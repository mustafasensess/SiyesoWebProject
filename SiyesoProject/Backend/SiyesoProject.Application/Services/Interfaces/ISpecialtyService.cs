using SiyesoProject.Domain.Entities;
using SiyesoProject.Infrastructure.DTOs;

namespace SiyesoProject.Application.Services.Interfaces;

public interface ISpecialtyService
{
    public Task<Response<List<Specialty>>> GetAll();

    public Task<Response<Specialty>> Delete(Specialty? specialty);

    public Task<Response<Specialty>> Update(Specialty? specialty);

    public Task<Response<Specialty>> Create(Specialty? specialty);
}