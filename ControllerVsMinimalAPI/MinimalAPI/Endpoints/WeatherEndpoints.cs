using MediatR;
using MinimalAPI.Commands;

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
            var command = new CreateWeatherCommand(temperature);
            await sender.Send(command);
            return Results.Ok();
        }

        //public static IResult GetWeather(int id, IMediator sender)
        //{
        //    return Results.Ok();
        //}
    }
}
