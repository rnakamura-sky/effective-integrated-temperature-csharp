namespace EffectiveIntegratedTemperature.Domain.ValueObjects
{
    public class Temperature : ValueObject<Temperature>
    {
        public double Value { get; }

        public Temperature(double value)
        {
            Value = value;
        }

        protected override bool EqualsCore(Temperature other)
        {
            return Value == other.Value;
        }

        protected override int GetHashCodeCore()
        {
            return Value.GetHashCode();
        }
    }
}
