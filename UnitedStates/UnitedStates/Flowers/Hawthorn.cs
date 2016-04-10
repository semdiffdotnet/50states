namespace UnitedStates.Flowers
{
    public class Hawthorn : IFlower
    {
        private Hawthorn()
        { }

        public static Hawthorn Instance { get; } = new Hawthorn();
        public string Name => "Hawthorn";
        public string BinomialNomenclature => "Crataegus";
    }
}