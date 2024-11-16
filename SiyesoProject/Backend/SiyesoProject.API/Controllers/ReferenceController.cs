using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SiyesoProject.Application.Services.Interfaces;
using SiyesoProject.Domain.Entities;
using SiyesoProject.Infrastructure.Controller;

namespace SiyesoProject.API.Controllers;

public class ReferenceController : CustomBaseController
{
    private readonly IReferenceService _service;

    public ReferenceController(IReferenceService service)
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
    public async Task<IActionResult> Delete(Reference? reference)
    {
        var response = await _service.Delete(reference);
        return CreateActionResultInstance(response);
    }
    
    [HttpPut]
    [Authorize]
    public async Task<IActionResult> Update(Reference? reference)
    {
        var response = await _service.Update(reference);
        return CreateActionResultInstance(response);
    }
    
    [HttpPost]
    [Authorize]
    public async Task<IActionResult> Create(Reference? reference)
    {
        var response = await _service.Create(reference);
        return CreateActionResultInstance(response);
    }
}