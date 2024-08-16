using MediatR;

namespace MinimalAPI.Commands;

public record CreateWeatherCommand(int Temperature) : IRequest;