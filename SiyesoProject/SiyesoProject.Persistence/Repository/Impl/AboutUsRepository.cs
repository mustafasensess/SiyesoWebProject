using Microsoft.EntityFrameworkCore;
using SiyesoProject.Domain.Entities;
using SiyesoProject.Persistence.Context;
using SiyesoProject.Persistence.Repository.Interfaces;

namespace SiyesoProject.Persistence.Repository.Impl;

public class AboutUsRepository : IAboutUsRepository
{
    private readonly ApplicationDbContext _dbContext;

    public AboutUsRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task<List<AboutUs>> GetAll()
    {
        var aboutUsList = await _dbContext.AboutUs.AsNoTracking().ToListAsync();
        return aboutUsList;
    }

    public async Task Delete(AboutUs aboutUs)
    {
        _dbContext.AboutUs.Remove(aboutUs);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<AboutUs> Update(AboutUs aboutUs)
    {
         _dbContext.AboutUs.Update(aboutUs);
         await _dbContext.SaveChangesAsync();
         return aboutUs;
    }

    public async Task<AboutUs> Create(AboutUs aboutUs)
    {
        await _dbContext.AboutUs.AddAsync(aboutUs);
        await _dbContext.SaveChangesAsync();
        return aboutUs;
    }

    public async Task<AboutUs?> GetById(int id)
    {
        var aboutUs = await _dbContext.AboutUs.FindAsync(id);
        return aboutUs;
    }
}