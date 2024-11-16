using SiyesoProject.Domain.Entities;

namespace SiyesoProject.Persistence.Repository.Interfaces;

public interface ISpecialtiesRepository
{
    public Task<List<Specialty>> GetAll();

    public Task Delete(Specialty specialty);

    public Task<Specialty> Update(Specialty specialty);

    public Task<Specialty> Create(Specialty specialty);

    public Task<Specialty?> GetById(int id);
}