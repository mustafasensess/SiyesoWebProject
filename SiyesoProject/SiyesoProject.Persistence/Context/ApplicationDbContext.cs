using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SiyesoProject.Domain.Entities;

namespace SiyesoProject.Persistence.Context;

public class ApplicationDbContext : IdentityDbContext<User>
{
    public ApplicationDbContext()
    {
        
    }

    public DbSet<Specialties> Specialties { get; set; }

    public DbSet<DigitalProblem> DigitalProblems { get; set; }
}