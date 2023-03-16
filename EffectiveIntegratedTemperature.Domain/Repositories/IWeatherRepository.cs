using EffectiveIntegratedTemperature.Domain.Entities;

namespace EffectiveIntegratedTemperature.Domain.Repositories
{
    public interface IWeatherRepository
    {
        WeatherEntity GetWeather(DateTime dateTime, int prefectureId, int areaBlockId);
    }
}
