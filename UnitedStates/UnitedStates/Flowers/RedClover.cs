namespace UnitedStates.Flowers
{
    public class RedClover : IFlower
    {
        private RedClover()
        { }

        public static RedClover Instance { get; } = new RedClover();
        public string Name => "Red Clover";
        public string BinomialNomenclature => "Trifolium pratense";
    }
}