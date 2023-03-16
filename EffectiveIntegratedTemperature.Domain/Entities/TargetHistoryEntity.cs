namespace EffectiveIntegratedTemperature.Domain.Entities
{
    public class TargetHistoryEntity
    {
        public int TargetGroupId { get; }
        public string TargetGroupName { get; }

        public TargetHistoryItemCollection TargetHistoryItemCollection { get; }

        private TargetEntity _targetEntity;

        public TargetHistoryEntity (TargetEntity targetEntity, IReadOnlyList<WeatherEntity> weathers)
        {
            _targetEntity = targetEntity;

            TargetGroupId = targetEntity.TargetGroupId;
            TargetGroupName = targetEntity.TargetGroupName;
        }
    }
}
