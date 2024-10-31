using Microsoft.AspNetCore.Mvc;
using SiyesoProject.Infrastructure.DTOs;

namespace SiyesoProject.Infrastructure.Controller;

[ApiController]
[Route("api/[controller]")]
public class CustomBaseController : ControllerBase
{
    protected static IActionResult CreateActionResultInstance<T>(Response<T> response)
    {
        return new ObjectResult(response)
        {
            StatusCode = response.StatusCode
        };
    }
}