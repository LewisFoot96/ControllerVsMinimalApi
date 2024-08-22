using OneOf;

namespace Common.WeatherResponses
{
    [GenerateOneOf]
    public partial class WeatherResponse : OneOfBase<WeatherResponse.Success, 
        WeatherResponse.Failure>
    {
        public record Success(int Value, string Message);
        public record Failure(string Message);
    }
}
