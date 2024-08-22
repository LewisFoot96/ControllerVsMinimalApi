using Common.Commands;
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
        var result = await _mediator.Send(new CreateWeatherCommand(temperature));

        return result.Match<IActionResult>(
            success => NoContent(),
            failure => BadRequest(failure.Message));
    }
}