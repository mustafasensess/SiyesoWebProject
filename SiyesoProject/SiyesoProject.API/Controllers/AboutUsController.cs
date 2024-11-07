using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SiyesoProject.Application.Services.Interfaces;
using SiyesoProject.Domain.Entities;
using SiyesoProject.Infrastructure.Controller;

namespace SiyesoProject.API.Controllers;

public class AboutUsController : CustomBaseController
{
    private readonly IAboutUsService _service;

    public AboutUsController(IAboutUsService service)
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
    public async Task<IActionResult> Delete(AboutUs aboutUs)
    {
        var response = await _service.Delete(aboutUs);
        return CreateActionResultInstance(response);
    }

    [HttpPut]
    [Authorize]
    public async Task<IActionResult> Update(AboutUs aboutUs)
    {
        var response = await _service.Update(aboutUs);
        return CreateActionResultInstance(response);
    }

    [HttpPost]
    [Authorize]
    public async Task<IActionResult> Create(AboutUs aboutUs)
    {
        var response = await _service.Create(aboutUs);
        return CreateActionResultInstance(response);
    }
    
}