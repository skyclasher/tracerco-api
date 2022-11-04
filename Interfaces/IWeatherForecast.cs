namespace tracerco_api.Interfaces
{
    public interface IWeatherForecast
    {
        IEnumerable<WeatherForecast> GetAllForecasts();

        WeatherForecast GetHottestForecast();
    }
}
