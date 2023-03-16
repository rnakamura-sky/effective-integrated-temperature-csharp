namespace EffectiveIntegratedTemperature.Domain.Entities
{
    public class TargetEntity
    {
        public int TargetGroupId { get; }
        public string TargetGroupName { get; }

        public IReadOnlyList<TargetStateEntity> Status { get; }

        public string Comment { get; }

        public TargetEntity(int targetGroupId, string targetGroupName, IReadOnlyList<TargetStateEntity> status, string comment)
        {
            TargetGroupId = targetGroupId;
            TargetGroupName = targetGroupName;
            Status = status;
            Comment = comment;
        }
    }
}
