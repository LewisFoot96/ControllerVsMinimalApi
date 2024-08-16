using ControllerAPI.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ControllerAPI.Controllers;

[ApiController]
[Route("api/weather")]
public class WeatherController : ControllerBase
{
    private readonly IMediator
        _mediator;

    public WeatherController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> CreateWeather([FromQuery] int temperature)
    {
        await _mediator.Send(new CreateWeatherCommand(temperature));

        return NoContent();
    }
}