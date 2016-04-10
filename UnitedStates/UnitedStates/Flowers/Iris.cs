namespace UnitedStates.Flowers
{
    public class Iris : IFlower
    {
        private Iris()
        { }

        public static Iris Instance { get; } = new Iris();
        public string Name => "Iris";
        public string BinomialNomenclature => "Iris";
    }
}