using MediatR;

namespace ControllerAPI.Commands;

public record CreateWeatherCommand(int Temperature) : IRequest;