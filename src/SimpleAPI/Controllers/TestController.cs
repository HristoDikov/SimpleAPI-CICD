using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{

    [HttpGet(Name = "Get")]
    public string Get()
    {
        return "Not master name";
    }
}
