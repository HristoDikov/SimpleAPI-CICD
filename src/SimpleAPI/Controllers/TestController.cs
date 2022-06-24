using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{

    [HttpGet(Name = "GetWeatherForecast")]
    public string Get()
    {
        return "Hristo Dikov";
    }
}

//
//  "date": "2022-06-26T11:32:04.1508295+03:00",
//     "temperatureC": 13,
//     "temperatureF": 55,
//     "summary": "Cool"
//   },
