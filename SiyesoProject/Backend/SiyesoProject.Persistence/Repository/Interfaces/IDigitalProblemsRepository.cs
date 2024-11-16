using SiyesoProject.Domain.Entities;

namespace SiyesoProject.Persistence.Repository.Interfaces;

public interface IDigitalProblemsRepository
{
    public Task<List<DigitalProblem>> GetAll();

    public Task Delete(DigitalProblem digitalProblem);

    public Task<DigitalProblem> Update(DigitalProblem digitalProblem);

    public Task<DigitalProblem> Create(DigitalProblem digitalProblem);

    public Task<DigitalProblem?> GetById(int id);
}