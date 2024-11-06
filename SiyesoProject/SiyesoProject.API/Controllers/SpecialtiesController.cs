using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SiyesoProject.Application.Services.Interfaces;
using SiyesoProject.Domain.Entities;
using SiyesoProject.Infrastructure.Controller;

namespace SiyesoProject.API.Controllers;

public class SpecialtiesController : CustomBaseController
{
    private readonly ISpecialtyService _service;

    public SpecialtiesController(ISpecialtyService service)
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
    public async Task<IActionResult> Delete(Specialty? specialty)
    {
        var response = await _service.Delete(specialty);
        return CreateActionResultInstance(response);
    }

    [HttpPut]
    [Authorize]
    public async Task<IActionResult> Update(Specialty? specialty)
    {
        var response = await _service.Update(specialty);
        return CreateActionResultInstance(response);
    }

    [HttpPost]
    [Authorize]
    public async Task<IActionResult> Create(Specialty? specialty)
    {
        var response = await _service.Create(specialty);
        return CreateActionResultInstance(response);
    }
}