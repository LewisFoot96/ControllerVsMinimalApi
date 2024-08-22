using Common.Commands;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace MinimalAPI.Endpoints
{
    public static class WeatherEndpoints
    {
        public static void MapWeatherEndpoints(this IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("api/weather");
            //Minimal apis use method injection
            group.MapPost("", CreateWeather);

            //group.MapGet("{id}", GetWeather);
        }

        public static async Task<IResult> CreateWeather(int temperature, IMediator sender)
        {
            var result = await sender.Send(new CreateWeatherCommand(temperature));

            return result.Match<IResult>(
                success => TypedResults.NoContent(),
                failure => TypedResults.BadRequest(failure.Message));
        }
    }
}
