using Microsoft.EntityFrameworkCore;
using SiyesoProject.Domain.Entities;
using SiyesoProject.Persistence.Context;
using SiyesoProject.Persistence.Repository.Interfaces;

namespace SiyesoProject.Persistence.Repository.Impl;

public class DigitalProblemsRepository : IDigitalProblemsRepository
{
    private readonly ApplicationDbContext _dbContext;

    public DigitalProblemsRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<List<DigitalProblem>> GetAll()
    {
        var digitalProblems = await _dbContext.DigitalProblems.AsNoTracking().ToListAsync();
        return digitalProblems;
    }

    public async Task Delete(DigitalProblem digitalProblem)
    {
        _dbContext.DigitalProblems.Remove(digitalProblem);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<DigitalProblem> Update(DigitalProblem digitalProblem)
    {
        _dbContext.DigitalProblems.Update(digitalProblem);
        await _dbContext.SaveChangesAsync();
        return digitalProblem;
    }

    public async Task<DigitalProblem> Create(DigitalProblem digitalProblem)
    {
        await _dbContext.DigitalProblems.AddAsync(digitalProblem);
        await _dbContext.SaveChangesAsync();
        return digitalProblem;
    }

    public async Task<DigitalProblem?> GetById(int id)
    {
        var digitalProblem = await _dbContext.DigitalProblems.FindAsync(id);
        return digitalProblem;
    }
}