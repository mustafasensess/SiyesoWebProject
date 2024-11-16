using SiyesoProject.Domain.Entities;
using SiyesoProject.Infrastructure.DTOs;

namespace SiyesoProject.Application.Services.Interfaces;

public interface ITeamService
{
    public Task<Response<List<Team>>> GetAll();

    public Task<Response<Team>> Delete(Team? teamMember);

    public Task<Response<Team>> Update(Team? teamMember);

    public Task<Response<Team>> Create(Team? teamMember);
}