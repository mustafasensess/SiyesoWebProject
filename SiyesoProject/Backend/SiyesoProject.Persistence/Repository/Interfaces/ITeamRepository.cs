using SiyesoProject.Domain.Entities;

namespace SiyesoProject.Persistence.Repository.Interfaces;

public interface ITeamRepository
{
    public Task<List<Team>> GetAll();

    public Task Delete(Team teamMember);

    public Task<Team> Update(Team teamMember);

    public Task<Team> Create(Team teamMember);

    public Task<Team?> GetById(int id);
}