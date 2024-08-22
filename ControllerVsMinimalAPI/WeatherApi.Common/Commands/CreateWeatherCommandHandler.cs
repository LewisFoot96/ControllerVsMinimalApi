using Common.WeatherResponses;
using MediatR;

namespace Common.Commands;

public class CreateWeatherCommandHandler : IRequestHandler<CreateWeatherCommand, WeatherResponse>
{
    public async Task<WeatherResponse> Handle(CreateWeatherCommand request, CancellationToken cancellationToken)
    {
        //Would likly have some async processing in the handler. 
        //Do something with the request
        if (request.Temperature > 100)
        {
            return new WeatherResponse.Success(100, "Very Hot");
        }
        return new WeatherResponse.Failure("Not so hot");
    }
}