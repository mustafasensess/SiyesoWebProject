using SiyesoProject.Application.Services.Interfaces;
using SiyesoProject.Domain.Entities;
using SiyesoProject.Infrastructure.DTOs;
using SiyesoProject.Persistence.Repository.Interfaces;

namespace SiyesoProject.Application.Services.Impl;

public class TeamService : ITeamService
{
    private readonly ITeamRepository _repository;

    public TeamService(ITeamRepository repository)
    {
        _repository = repository;
    }
    
    public async Task<Response<List<Team>>> GetAll()
    {
        return Response<List<Team>>.Success(await _repository.GetAll(), 200);
    }

    public async Task<Response<Team>> Delete(Team? teamMember)
    {
        if (teamMember == null)
        {
            return Response<Team>.Fail("Not Found", 404);
        }

        await _repository.Delete(teamMember);
        return Response<Team>.Success(teamMember, 200);
    }

    public async Task<Response<Team>> Update(Team? teamMember)
    {
        if (teamMember == null)
        {
            return Response<Team>.Fail("Not Found", 404);
        }

        await _repository.Update(teamMember);
        return Response<Team>.Success(teamMember, 200);
    }

    public async Task<Response<Team>> Create(Team? teamMember)
    {
        if (teamMember == null)
        {
            return Response<Team>.Fail("Not Found", 404);
        }

        await _repository.Create(teamMember);
        return Response<Team>.Success(teamMember, 200);
    }
}