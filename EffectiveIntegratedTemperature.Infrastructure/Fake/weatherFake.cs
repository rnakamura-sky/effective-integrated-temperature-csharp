using EffectiveIntegratedTemperature.Domain.Entities;
using EffectiveIntegratedTemperature.Domain.Repositories;

namespace EffectiveIntegratedTemperature.Infrastructure.Fake
{
    public class weatherFake : IWeatherRepository
    {
        public WeatherEntity GetWeather(DateTime dateTime, int prefectureId, int areaBlockId)
        {
            var temperature = 20.0;
            return new WeatherEntity(dateTime, prefectureId, areaBlockId, temperature);
        }
    }
}
