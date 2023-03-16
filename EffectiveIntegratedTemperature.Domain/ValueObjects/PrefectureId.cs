namespace EffectiveIntegratedTemperature.Domain.ValueObjects
{
    public class PrefectureId : ValueObject<PrefectureId>
    {
        public int Value;

        public PrefectureId(int value)
        {
            Value = value;
        }

        protected override bool EqualsCore(PrefectureId other)
        {
            return Value == other.Value;
        }

        protected override int GetHashCodeCore()
        {
            return Value.GetHashCode();
        }
    }
}
