using Common.WeatherResponses;
using MediatR;

namespace Common.Commands;

public record CreateWeatherCommand(int Temperature) : IRequest<WeatherResponse>;