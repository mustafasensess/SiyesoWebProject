using Microsoft.EntityFrameworkCore;
using SiyesoProject.Domain.Entities;
using SiyesoProject.Persistence.Context;
using SiyesoProject.Persistence.Repository.Interfaces;

namespace SiyesoProject.Persistence.Repository.Impl;

public class ReferenceRepository : IReferenceRepository
{
    private readonly ApplicationDbContext _dbContext;

    public ReferenceRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<List<Reference>> GetAll()
    {
        var references = await _dbContext.References.AsNoTracking().ToListAsync();
        return references;
    }

    public async Task Delete(Reference reference)
    {
        _dbContext.References.Remove(reference);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<Reference> Update(Reference reference)
    {
        _dbContext.References.Update(reference);
        await _dbContext.SaveChangesAsync();
        return reference;
    }

    public async Task<Reference> Create(Reference reference)
    {
        await _dbContext.References.AddAsync(reference);
        await _dbContext.SaveChangesAsync();
        return reference;
    }

    public async Task<Reference?> GetById(int id)
    {
        var reference = await _dbContext.References.FindAsync(id);
        return reference;
    }
}