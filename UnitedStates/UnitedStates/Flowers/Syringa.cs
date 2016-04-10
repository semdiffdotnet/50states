namespace UnitedStates.Flowers
{
    public class Syringa : IFlower
    {
        private Syringa()
        { }

        public static Syringa Instance { get; } = new Syringa();
        public string Name => "Syringa";
        public string BinomialNomenclature => "Philadelphus lewisii";
    }
}