namespace UnitedStates.Flowers
{
    public class BigRhododendron : IFlower
    {
        private BigRhododendron()
        { }

        public static BigRhododendron Instance { get; } = new BigRhododendron();
        public string Name => "Big Rhododendron";
    }
}