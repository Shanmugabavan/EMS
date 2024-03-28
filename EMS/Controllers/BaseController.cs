using Microsoft.AspNetCore.Mvc;

namespace EMS.Controllers;

[Route("api/[controller]")]
[ApiController]
[Produces("application/json")]
public class BaseController : ControllerBase
{
}
