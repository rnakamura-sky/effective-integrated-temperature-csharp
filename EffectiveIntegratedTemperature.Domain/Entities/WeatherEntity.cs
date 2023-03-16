using EffectiveIntegratedTemperature.Domain.ValueObjects;

namespace EffectiveIntegratedTemperature.Domain.Entities
{
    public class WeatherEntity
    {
        public DateTime Date { get; }
        public PrefectureId PrefectureId { get; }
        public AreaBlockId AreaBlockId { get; }
        public Temperature Temperature { get; }

        public WeatherEntity(DateTime date, int prefectureId, int areaBlockId, double temperature)
        {
            Date = date;
            PrefectureId = new PrefectureId(prefectureId);
            AreaBlockId = new AreaBlockId(areaBlockId);
            Temperature = new Temperature(temperature);
        }
    }
}
