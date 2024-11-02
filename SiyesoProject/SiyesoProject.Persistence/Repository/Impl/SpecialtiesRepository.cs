using Microsoft.EntityFrameworkCore;
using SiyesoProject.Domain.Entities;
using SiyesoProject.Persistence.Context;
using SiyesoProject.Persistence.Repository.Interfaces;

namespace SiyesoProject.Persistence.Repository.Impl;

public class SpecialtiesRepository : ISpecialtiesRepository
{
    private readonly ApplicationDbContext _dbContext;

    public SpecialtiesRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<List<Specialty>> GetAll()
    {
        var specialties = await _dbContext.Specialties.AsNoTracking().ToListAsync();
        return specialties;
    }

    public async Task Delete(Specialty specialty)
    {
        _dbContext.Specialties.Remove(specialty);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<Specialty> Update(Specialty specialty)
    {
        _dbContext.Specialties.Update(specialty);
        await _dbContext.SaveChangesAsync();
        return specialty;
    }

    public async Task<Specialty> Create(Specialty specialty)
    {
        await _dbContext.Specialties.AddAsync(specialty);
        await _dbContext.SaveChangesAsync();
        return specialty;
    }

    public async Task<Specialty?> GetById(int id)
    {
        var specialty = await _dbContext.Specialties.FindAsync(id);
        return specialty;
    }
}