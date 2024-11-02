using Microsoft.AspNetCore.Mvc;
using SiyesoProject.Application.Services.Interfaces;
using SiyesoProject.Domain.Entities;
using SiyesoProject.Infrastructure.Controller;

namespace SiyesoProject.API.Controllers;

public class TeamController : CustomBaseController
{
    private readonly ITeamService _service;

    public TeamController(ITeamService service)
    {
        _service = service;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var response = await _service.GetAll();
        return CreateActionResultInstance(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(Team? teamMember)
    {
        var response = await _service.Delete(teamMember);
        return CreateActionResultInstance(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update(Team? teamMember)
    {
        var response = await _service.Update(teamMember);
        return CreateActionResultInstance(response);
    }

    [HttpPost]
    public async Task<IActionResult> Create(Team? teamMember)
    {
        var response = await _service.Create(teamMember);
        return CreateActionResultInstance(response);
    }
}