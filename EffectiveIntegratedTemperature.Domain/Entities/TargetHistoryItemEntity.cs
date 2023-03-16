using EffectiveIntegratedTemperature.Domain.ValueObjects;

namespace EffectiveIntegratedTemperature.Domain.Entities
{
    public class TargetHistoryItemEntity
    {
        public DateTime DateTime { get; }
        public int TargetGroupId { get; }
        public string TargetGroupName { get; }
        public int TargetStateId { get; }
        public string TargetStateName { get; }
        public double ZeroTemperature { get; }
        public double EffectiveIntegratedTemperature { get; }
        public Temperature Temperature { get; }

        public double DiffTemperature { get; }

        public TargetHistoryItemEntity(
            DateTime dateTime,
            int targetGroupId,
            string targetGroupName,
            int targetStateId,
            string targetStateName,
            double zeroTemperature,
            double effectiveIntegratedTemperature,
            Temperature temperature,
            double diffTemperature)
        {
            DateTime = dateTime;
            TargetGroupId = targetGroupId;
            TargetGroupName = targetGroupName;
            TargetStateId = targetStateId;
            TargetStateName = targetStateName;
            ZeroTemperature = zeroTemperature;
            EffectiveIntegratedTemperature = effectiveIntegratedTemperature;
            Temperature = temperature;
            DiffTemperature = diffTemperature;
        }
    }
}
