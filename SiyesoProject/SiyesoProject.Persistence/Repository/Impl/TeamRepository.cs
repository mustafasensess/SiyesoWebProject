using Microsoft.EntityFrameworkCore;
using SiyesoProject.Domain.Entities;
using SiyesoProject.Persistence.Context;
using SiyesoProject.Persistence.Repository.Interfaces;

namespace SiyesoProject.Persistence.Repository.Impl;

public class TeamRepository : ITeamRepository
{
    private readonly ApplicationDbContext _dbContext;

    public TeamRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<List<Team>> GetAll()
    {
        var teamMembers = await _dbContext.TeamMembers.AsNoTracking().ToListAsync();
        return teamMembers;
    }

    public async Task Delete(Team teamMember)
    {
        _dbContext.TeamMembers.Remove(teamMember);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<Team> Update(Team teamMember)
    {
        _dbContext.TeamMembers.Update(teamMember);
        await _dbContext.SaveChangesAsync();
        return teamMember;
    }

    public async Task<Team> Create(Team teamMember)
    {
        await _dbContext.TeamMembers.AddAsync(teamMember);
        await _dbContext.SaveChangesAsync();
        return teamMember;
    }

    public async Task<Team?> GetById(int id)
    {
        var teamMember = await _dbContext.TeamMembers.FindAsync(id);
        return teamMember;
    }
}