using MediatR;

namespace MinimalAPI.Commands;

public class CreateWeatherCommandHandler : IRequestHandler<CreateWeatherCommand>
{
    public Task Handle(CreateWeatherCommand request, CancellationToken cancellationToken)
    {
        //Do something with the request
        throw new NotImplementedException();
    }
}