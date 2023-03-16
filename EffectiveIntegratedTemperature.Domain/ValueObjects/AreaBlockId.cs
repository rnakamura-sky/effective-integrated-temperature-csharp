namespace EffectiveIntegratedTemperature.Domain.ValueObjects
{
    public class AreaBlockId : ValueObject<AreaBlockId>
    {
        public int Value { get; }

        public AreaBlockId(int value)
        {
            Value = value;
        }

        protected override bool EqualsCore(AreaBlockId other)
        {
            return Value == other.Value;
        }

        protected override int GetHashCodeCore()
        {
            return Value.GetHashCode();
        }
    }
}
