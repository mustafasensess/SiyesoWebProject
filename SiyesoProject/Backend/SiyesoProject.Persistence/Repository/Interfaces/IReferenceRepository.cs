using SiyesoProject.Domain.Entities;

namespace SiyesoProject.Persistence.Repository.Interfaces;

public interface IReferenceRepository
{
    public Task<List<Reference>> GetAll();

    public Task Delete(Reference reference);

    public Task<Reference> Update(Reference reference);

    public Task<Reference> Create(Reference reference);

    public Task<Reference?> GetById(int id);
}