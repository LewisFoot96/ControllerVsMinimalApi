using FastEndpoints;

namespace FastEndpointsAPI
{
    public class GetWeatherEndpoint : EndpointWithoutRequest<WeatherResponse>
    {
        public override void Configure()
        {
            Get("/weather");
            AllowAnonymous();
        }

        public override Task<WeatherResponse> ExecuteAsync(CancellationToken ct)
        {
            WeatherResponse repsponse = new WeatherResponse
            {
                Temperaure = 1
            };

            return Task.FromResult(repsponse);
        }

        //public override async Task HandleAsync(CancellationToken ct)
        //{
        //    WeatherResponse repsponse = new WeatherResponse
        //    {
        //        Temperaure = 1
        //    };

        //    await SendOkAsync(repsponse);
        //}
    }
}
