namespace EffectiveIntegratedTemperature.Domain.ValueObjects
{
    public class TargetType : ValueObject<TargetType>
    {
        public static readonly TargetType Insect = new TargetType(1, "Insect", "虫");
        public static readonly TargetType Plant = new TargetType(2, "Plant", "植物");
        public static readonly TargetType Empty = new TargetType(-1, "", "");

        public int Id { get; }
        public string Code { get; }
        public string Name { get; }


        private TargetType(int id, string code, string name)
        {
            Id = id;
            Code = code;
            Name = name;
        }

        public static IReadOnlyList<TargetType> ToList()
        {
            return new List<TargetType>()
            {
                Insect,
                Plant,
            }.AsReadOnly();
        }

        public static TargetType GetTargetType(int id)
        {
            var result = ToList().Where(x => x.Id == id).FirstOrDefault();

            if (result is null)
            {
                return Empty;
            }
            return result;
        }


        protected override bool EqualsCore(TargetType other)
        {
            return Id == other.Id;
        }

        protected override int GetHashCodeCore()
        {
            return Id.GetHashCode();
        }
    }
}
