using EffectiveIntegratedTemperature.Domain.ValueObjects;

namespace EffectiveIntegratedTemperature.Domain.Entities
{
    public class TargetGroupEntity
    {
        public int TargetGroupId { get; }
        public TargetType TargetType { get; }

        public string TargetName { get; }

        public string Comment { get; }

        public TargetGroupEntity(int tagetGroupId, int targetType, string targetName, string comment)
        {
            TargetGroupId = tagetGroupId;
            TargetType = TargetType.GetTargetType(targetType);
            TargetName = targetName;
            Comment = comment;
        }
    }
}
