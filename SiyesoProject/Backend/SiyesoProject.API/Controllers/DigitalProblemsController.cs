using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SiyesoProject.Application.Services.Interfaces;
using SiyesoProject.Domain.Entities;
using SiyesoProject.Infrastructure.Controller;

namespace SiyesoProject.API.Controllers;

public class DigitalProblemsController : CustomBaseController
{
    private readonly IDigitalProblemService _service;

    public DigitalProblemsController(IDigitalProblemService service)
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
    [Authorize]
    public async Task<IActionResult> Delete(DigitalProblem? digitalProblem)
    {
        var response = await _service.Delete(digitalProblem);
        return CreateActionResultInstance(response);
    }

    [HttpPut]
    [Authorize]
    public async Task<IActionResult> Update(DigitalProblem? digitalProblem)
    {
        var response = await _service.Update(digitalProblem);
        return CreateActionResultInstance(response);
    }

    [HttpPost]
    [Authorize]
    public async Task<IActionResult> Create(DigitalProblem? digitalProblem)
    {
        var response = await _service.Create(digitalProblem);
        return CreateActionResultInstance(response);
    }
}