using SiyesoProject.Domain.Entities;

namespace SiyesoProject.Persistence.Repository.Interfaces;

public interface IAboutUsRepository
{
    public Task<List<AboutUs>> GetAll();

    public Task Delete(AboutUs aboutUs);

    public Task<AboutUs> Update(AboutUs aboutUs);

    public Task<AboutUs> Create(AboutUs aboutUs);

    public Task<AboutUs?> GetById(int id);
}