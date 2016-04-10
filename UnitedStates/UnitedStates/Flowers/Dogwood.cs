namespace UnitedStates.Flowers
{
    public class Dogwood : IFlower
    {
        private Dogwood()
        { }

        public static Dogwood Instance { get; } = new Dogwood();
        public string Name => "Dogwood";
        public string BinomialNomenclature => "Cornus florida";
    }
}