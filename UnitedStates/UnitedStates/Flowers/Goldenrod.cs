namespace UnitedStates.Flowers
{
    public class Goldenrod : IFlower
    {
        private Goldenrod()
        { }

        public static Goldenrod Instance { get; } = new Goldenrod();
        public string Name => "Goldenrod";
    }
}