using FastEndpoints;

namespace FastEndpointsAPI
{
    public class MyEndpoint : Endpoint<int, int>
    {
        public override void Configure()
        {
            Post("/api/user/create");
            AllowAnonymous();
        }

        public override async Task HandleAsync(int req, CancellationToken ct)
        {
            await SendAsync(2);
        }
    }
}
