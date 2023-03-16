namespace EffectiveIntegratedTemperature.Domain.Entities
{
    public class TargetStateEntity
    {
        public int TargetGroupId { get; }
        public int TargetStateId { get; }
        public string TargetStateName { get; }
        public double ZeroTemperature { get; }
        public double EffectiveIntegratedTemperature { get; }

        public string Comment { get; }

        public TargetStateEntity (
            int targetGroupId,
            int targetStateId,
            string targetStateName,
            double zeroTemperature,
            double effectiveIntegratedTemperature,
            string comment)
        {
            TargetGroupId = targetGroupId;
            TargetStateId = targetStateId;
            TargetStateName = targetStateName;
            ZeroTemperature = zeroTemperature;
            EffectiveIntegratedTemperature = effectiveIntegratedTemperature;
            Comment = comment;
        }
    }
}
